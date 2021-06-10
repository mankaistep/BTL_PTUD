using BTL_PTUD.Source.Objects;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_PTUD.Source.Connection {

    class SQLConnections {

        public static SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-S4GU3GQ\SQLEXPRESS;Initial Catalog=phanmemthi;Integrated Security=SSPI");

        public static void Init(string s) {
            Connection = new SqlConnection();
            Connection.ConnectionString = s;
            Connection.Open();
        }

        public static int QueryCurrentExamAmount(string teacherID) {

            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"SELECT COUNT(*) FROM Exams WHERE Start_date <= GETDATE() AND End_date >= GETDATE() AND teacher_id=@id";

            var idParam = new SqlParameter("@id", System.Data.SqlDbType.VarChar, 50);
            idParam.Value = teacherID;

            cmd.Parameters.Add(idParam);
            cmd.Prepare();

            var reader = cmd.ExecuteReader();

            int r = 0;

            using (cmd)
            using (reader) {
                while (reader.Read()) {
                    r = Convert.ToInt32(reader[0]);
                }
            }

            return r;
        }

        public static int QueryExamAmount() {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"SELECT COUNT(*) FROM Exams";
            var reader = cmd.ExecuteReader();

            int r = 0;

            using (cmd)
            using (reader) {
                while (reader.Read()) {
                    r = Convert.ToInt32(reader[0]);
                }
            }

            return r;
        }

        public static Student QueryStudent(string id) {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"SELECT Student_name, Birthday, Department from Students where Student_id=@id";
            var idParam = new SqlParameter("@id", System.Data.SqlDbType.VarChar, 50);
            idParam.Value = id;

            cmd.Parameters.Add(idParam);
            cmd.Prepare();

            var reader = cmd.ExecuteReader();
            Teacher t = null;

            using (cmd)
            using (reader) {
                while (reader.Read()) {
                    string name = reader[0].ToString();
                    DateTime birthDay = DateTime.Parse(reader[1].ToString());
                    string department = reader[2].ToString();
                    return new Student(id, name, birthDay, department);
                }
            }

            return null;
        }

        public static Teacher QueryTeacher(string id) {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"SELECT Teacher_name, Subject_id, Department, mail from Teachers where Teacher_id=@id";
            var idParam = new SqlParameter("@id", System.Data.SqlDbType.VarChar, 50);
            idParam.Value = id;

            cmd.Parameters.Add(idParam);
            cmd.Prepare();

            var reader = cmd.ExecuteReader();
            Teacher t = null;

            using (cmd)
            using (reader) {
                while (reader.Read()) {
                    string name = reader[0].ToString();
                    string subjectID = reader[1].ToString();
                    string department = reader[2].ToString();
                    string mail = reader[3].ToString();
                    t = new Teacher(id, name, subjectID, department, mail);
                }
            }

            return t;
        }

        public static List<Class> QueryClasses(String teacherID) {
            List<Class> list = new List<Class>();

            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"SELECT Class_id, Class_name, Subject_id from Classes where Teacher_id=@id";
            var idParam = new SqlParameter("@id", System.Data.SqlDbType.VarChar, 50);
            idParam.Value = teacherID;

            cmd.Parameters.Add(idParam);
            cmd.Prepare();

            var reader = cmd.ExecuteReader();

            using (cmd)
            using (reader) {
                while (reader.Read()) {
                    string id = reader[0].ToString();
                    string name = reader[1].ToString();
                    string subjectid = reader[2].ToString();
                    list.Add(new Class(id, teacherID, name, subjectid));
                }
            }

            return list;
        }

        public static List<Exam> QueryExams(Class cls, bool queryQuestions) {
            List<Exam> list = new List<Exam>();

            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"SELECT Exam_id, Creation_date, Time, Exam_order, Start_date, End_date, limited_times, number_question from Exams where Class_id=@id";
            var idParam = new SqlParameter("@id", System.Data.SqlDbType.VarChar, 50);
            idParam.Value = cls.ID;

            cmd.Parameters.Add(idParam);
            cmd.Prepare();

            var reader = cmd.ExecuteReader();

            using (cmd)
            using (reader) {
                while (reader.Read()) {
                    string id = reader[0].ToString();
                    string teacherID = cls.TeacherID;
                    string classID = cls.ID;
                    DateTime creationDate = DateTime.Parse(reader[1].ToString());
                    int time = Convert.ToInt32(reader[2].ToString());
                    string examOrder = reader[3].ToString();
                    DateTime startDate = DateTime.Parse(reader[4].ToString());
                    DateTime endDate = DateTime.Parse(reader[5].ToString());
                    int limit = Convert.ToInt32(reader[6].ToString());
                    int numberQuestion = Convert.ToInt32(reader[7].ToString());

                    list.Add(new Exam(id, teacherID, classID, creationDate, time, examOrder, startDate, endDate, limit, numberQuestion));
                }
            }

            if (queryQuestions) {
                foreach (var exam in list) {
                    exam.Questions = QueryQuestions(exam.ID);
                }
            }

            return list;
        }

        public static List<Exam> QueryExams(string teacherID, bool queryQuestions, bool notYetStarted) {
            List<Exam> list = new List<Exam>();

            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"SELECT Exam_id, Class_id, Creation_date, Time, Exam_order, Start_date, End_date, limited_times, number_question from Exams where teacher_id=@id";
            var idParam = new SqlParameter("@id", System.Data.SqlDbType.VarChar, 50);
            idParam.Value = teacherID;

            cmd.Parameters.Add(idParam);
            cmd.Prepare();

            var reader = cmd.ExecuteReader();

            using (cmd)
            using (reader) {
                while (reader.Read()) {
                    DateTime startDate = DateTime.Parse(reader[5].ToString());
                    if (notYetStarted && DateTime.Compare(startDate, DateTime.Now) < 0) continue;

                    string id = reader[0].ToString();
                    string classID = reader[1].ToString();
                    DateTime creationDate = DateTime.Parse(reader[2].ToString());
                    int time = Convert.ToInt32(reader[3].ToString());
                    string examOrder = reader[4].ToString();
                    DateTime endDate = DateTime.Parse(reader[6].ToString());
                    int limit = Convert.ToInt32(reader[7].ToString());
                    int numberQuestion = Convert.ToInt32(reader[8].ToString());

                    list.Add(new Exam(id, teacherID, classID, creationDate, time, examOrder, startDate, endDate, limit, numberQuestion));
                }
            }

            if (queryQuestions) {
                foreach (var exam in list) {
                    exam.Questions = QueryQuestions(exam.ID);
                }
            }

            return list;
        }

        public static Exam QueryExam(string id, bool queryQuestions) {
            Exam exam = null;

            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"SELECT teacher_id, Class_id, Creation_date, Time, Exam_order, Start_date, End_date, limited_times, number_question from Exams where Exam_id=@id";
            var idParam = new SqlParameter("@id", System.Data.SqlDbType.VarChar, 50);
            idParam.Value = id;

            cmd.Parameters.Add(idParam);
            cmd.Prepare();

            var reader = cmd.ExecuteReader();

            using (cmd)
            using (reader) {
                while (reader.Read()) {
                    string teacherID = reader[0].ToString();
                    string classID = reader[1].ToString();
                    DateTime creationDate = DateTime.Parse(reader[2].ToString());
                    int time = Convert.ToInt32(reader[3].ToString());
                    string examOrder = reader[4].ToString();
                    DateTime startDate = DateTime.Parse(reader[5].ToString());
                    DateTime endDate = DateTime.Parse(reader[6].ToString());
                    int limit = Convert.ToInt32(reader[7].ToString());
                    int numberQuestion = Convert.ToInt32(reader[8].ToString());

                    exam = new Exam(id, teacherID, classID, creationDate, time, examOrder, startDate, endDate, limit, numberQuestion);
                }
            }

            if (queryQuestions) {
                exam.Questions = QueryQuestions(exam.ID);
            }

            return exam;
        }

        public static List<Question> QueryQuestions(string examID) {
            List<Question> list = new List<Question>();

            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"SELECT Question_id, Question from Question where Exam_id=@id";
            var idParam = new SqlParameter("@id", System.Data.SqlDbType.VarChar, 50);
            idParam.Value = examID;

            cmd.Parameters.Add(idParam);
            cmd.Prepare();

            var reader = cmd.ExecuteReader();

            using (cmd)
            using (reader) {
                while (reader.Read()) {
                    string id = reader[0].ToString();
                    string question = reader[1].ToString();

                    list.Add(new Question(id, examID, question));
                }
            }

            foreach (var question in list) {
                question.Answers = QueryAnswers(question.ID);
            }

            return list;
        }

        public static List<Answer> QueryAnswers(string questionID) {
            List<Answer> list = new List<Answer>();

            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"SELECT Anwer_id, Anwer, is_true from Answer where Question_id=@id";
            var idParam = new SqlParameter("@id", System.Data.SqlDbType.VarChar, 50);
            idParam.Value = questionID;

            cmd.Parameters.Add(idParam);
            cmd.Prepare();

            var reader = cmd.ExecuteReader();

            using (cmd)
            using (reader) {
                while (reader.Read()) {
                    string id = reader[0].ToString();
                    string answer = reader[1].ToString();
                    bool isTrue = Convert.ToBoolean(reader[2].ToString());

                    list.Add(new Answer(id, questionID, answer, isTrue));
                }
            }

            return list;
        }

        public static List<Result> QueryResults(string examID, bool extra) {
            List<Result> list = new List<Result>();

            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"SELECT Result_id, Student_id, Score, Date, Access_time, times from Student_Exam_Result where Exam_id=@id";
            var idParam = new SqlParameter("@id", System.Data.SqlDbType.VarChar, 50);
            idParam.Value = examID;

            cmd.Parameters.Add(idParam);
            cmd.Prepare();

            var reader = cmd.ExecuteReader();

            using (cmd)
            using (reader) {
                while (reader.Read()) {
                    string id = reader[0].ToString();
                    string studentID = reader[1].ToString();
                    float score = Convert.ToSingle(Math.Round(Convert.ToDouble(reader[2].ToString()), 2));
                    var date = DateTime.Parse(reader[3].ToString());
                    int accessTime = Convert.ToInt32(reader[4].ToString());
                    int times = Convert.ToInt32(reader[5].ToString());

                    list.Add(new Result(id, studentID, examID, score, date, accessTime, times));
                }
            }

            if (extra) {
                foreach (var result in list) {
                    result.StudentName = QueryStudent(result.StudentID).Name;
                }
            }

            return list;
        }

        public static Question QueryQuestion(String id) {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"SELECT * from Question where Question_id=@id";
            var idParam = new SqlParameter("@id", System.Data.SqlDbType.VarChar, 50);
            idParam.Value = id;

            cmd.Parameters.Add(idParam);
            cmd.Prepare();

            var reader = cmd.ExecuteReader();

            using (cmd)
            using (reader) {
                while (reader.Read()) {
                    string examID = reader[1].ToString();
                    string question = reader[2].ToString();

                    return new Question(id, examID, question);
                }
            }

            return null;
        }

        public static Answer QueryAnswer(String id) {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"SELECT * from Answer where Anwer_id=@id";
            var idParam = new SqlParameter("@id", System.Data.SqlDbType.VarChar, 50);
            idParam.Value = id;

            cmd.Parameters.Add(idParam);
            cmd.Prepare();

            var reader = cmd.ExecuteReader();

            using (cmd)
            using (reader) {
                while (reader.Read()) {
                    string questionID = reader[1].ToString();
                    string answer = reader[2].ToString();
                    bool isTrue = Boolean.Parse(reader[3].ToString());

                    return new Answer(id, questionID, answer, isTrue);
                }
            }

            return null;
        }

        public static List<Choice> QueryChoices(string resultID, bool extra) {
            List<Choice> list = new List<Choice>();

            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"SELECT Choise_history_id, Question_id, Answer_id from Student_Choice where Result_id=@id";
            var idParam = new SqlParameter("@id", System.Data.SqlDbType.VarChar, 50);
            idParam.Value = resultID;

            cmd.Parameters.Add(idParam);
            cmd.Prepare();

            var reader = cmd.ExecuteReader();

            using (cmd)
            using (reader) {
                while (reader.Read()) {
                    string id = reader[0].ToString();
                    string questionID = reader[1].ToString();
                    string answerID = reader[2].ToString();

                    list.Add(new Choice(id, resultID, answerID, questionID));
                }
            }

            if (extra) {
                foreach (var choice in list) {
                    choice.Question = QueryQuestion(choice.QuestionID).Content;

                    var answer = QueryAnswer(choice.AnswerID);
                    choice.Answer = answer.Content;
                    choice.IsTrue = answer.IsTrue;
                }
            }

            return list;
        }

        public static int QueryQuestionAmount() {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"SELECT COUNT(*) from Question";

            var reader = cmd.ExecuteReader();

            using (cmd)
            using (reader) {
                while (reader.Read()) {
                    return Convert.ToInt32(reader[0]);
                }
            }

            return 0;
        }

        public static bool SaveExam(Exam exam) {
            int qadd = 0;
            SqlCommand cmd;
            SqlParameter idParam;

            // Check no-id exam
            if (exam.ID == null) {
                exam.ID = "ex" + (QueryExamAmount() + 1);
            }
            
            // Check no-id questions
            foreach (var q in exam.Questions) {
                if (q.ID == null) {
                    q.ExamID = exam.ID;
                    q.ID = "q" + (QueryQuestionAmount() + qadd + 1);
                    qadd++;
                }

                // Check no-id answers
                for (int i = 0; i < q.Answers.Count; i++) {
                    var a = q.Answers[i];
                    a.QuestionID = q.ID;
                    a.ID = q.ID + "ans" + (i + 1);
                }
            }

            // Start transaction
            var transaction = Connection.BeginTransaction("SaveExam");

            try {
                // Clear answers
                foreach (var q in exam.Questions) {
                    using (cmd = new SqlCommand()) {
                        cmd.Connection = Connection;
                        cmd.Transaction = transaction;
                        cmd.CommandText = @"DELETE FROM Answer where Question_id=@id";
                        idParam = new SqlParameter("@id", System.Data.SqlDbType.VarChar, 50);

                        idParam.Value = q.ID;
                        cmd.Parameters.Add(idParam);

                        cmd.Prepare();
                        cmd.ExecuteNonQuery();
                    }
                }

                // Clear questions
                using (cmd = new SqlCommand()) {
                    cmd.Connection = Connection;
                    cmd.Transaction = transaction;
                    cmd.CommandText = @"DELETE FROM Question where Exam_id=@id";
                    idParam = new SqlParameter("@id", System.Data.SqlDbType.VarChar, 50);

                    idParam.Value = exam.ID;
                    cmd.Parameters.Add(idParam);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }


                // Clear exam
                using (cmd = new SqlCommand()) {
                    cmd.Connection = Connection;
                    cmd.Transaction = transaction;
                    cmd.CommandText = @"DELETE FROM Exams where Exam_id=@id";
                    idParam = new SqlParameter("@id", System.Data.SqlDbType.VarChar, 50);

                    idParam.Value = exam.ID;
                    cmd.Parameters.Add(idParam);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }

                // Insert exam
                using (cmd = new SqlCommand()) {
                    cmd.Connection = Connection;
                    cmd.Transaction = transaction;
                    cmd.CommandText = @"INSERT INTO Exams VALUES (@Exam_id, @teacher_id, @Class_id, @Creation_Date, @Time, @Exam_order, @Start_date, @End_date, @limited_times, @number_question)";

                    var examIDParam = new SqlParameter("@Exam_id", System.Data.SqlDbType.VarChar, 50);
                    var teacherIDParam = new SqlParameter("@teacher_id", System.Data.SqlDbType.VarChar, 50);
                    var classIDParam = new SqlParameter("@Class_id", System.Data.SqlDbType.VarChar, 50);
                    var creationDateParam = new SqlParameter("@Creation_Date", System.Data.SqlDbType.DateTime);
                    var timeParam = new SqlParameter("@Time", System.Data.SqlDbType.Int);
                    var examOrderParam = new SqlParameter("@Exam_order", System.Data.SqlDbType.NVarChar, 50);
                    var startDateParam = new SqlParameter("@Start_date", System.Data.SqlDbType.DateTime);
                    var endDateParam = new SqlParameter("@End_date", System.Data.SqlDbType.DateTime);
                    var limitedTimesParam = new SqlParameter("@limited_times", System.Data.SqlDbType.Int);
                    var numberQuestionParam = new SqlParameter("@number_question", System.Data.SqlDbType.Int);

                    examIDParam.Value = exam.ID;
                    teacherIDParam.Value = exam.TeacherID;
                    classIDParam.Value = exam.ClassID;
                    creationDateParam.Value = exam.CreationDate;
                    timeParam.Value = exam.Time;
                    examOrderParam.Value = exam.ExamOrder;
                    startDateParam.Value = exam.StartDate;
                    endDateParam.Value = exam.EndDate;
                    limitedTimesParam.Value = exam.Limit;
                    numberQuestionParam.Value = exam.NumberQuestion;

                    cmd.Parameters.Add(examIDParam);
                    cmd.Parameters.Add(teacherIDParam);
                    cmd.Parameters.Add(classIDParam);
                    cmd.Parameters.Add(creationDateParam);
                    cmd.Parameters.Add(timeParam);
                    cmd.Parameters.Add(examOrderParam);
                    cmd.Parameters.Add(startDateParam);
                    cmd.Parameters.Add(endDateParam);
                    cmd.Parameters.Add(limitedTimesParam);
                    cmd.Parameters.Add(numberQuestionParam);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }

                // Insert questions
                foreach (var q in exam.Questions) {
                    using (cmd = new SqlCommand()) {
                        cmd.Connection = Connection;
                        cmd.Transaction = transaction;
                        cmd.CommandText = @"INSERT INTO Question VALUES (@Question_id, @Exam_id, @Question)";

                        var qIDParam = new SqlParameter("@Question_id", System.Data.SqlDbType.VarChar, 50);
                        var examIDParam = new SqlParameter("@Exam_id", System.Data.SqlDbType.VarChar, 50);
                        var qQParam = new SqlParameter("@Question", System.Data.SqlDbType.NVarChar, 500);

                        qIDParam.Value = q.ID;
                        examIDParam.Value = q.ExamID;
                        qQParam.Value = q.Content;

                        cmd.Parameters.Add(qIDParam);
                        cmd.Parameters.Add(examIDParam);
                        cmd.Parameters.Add(qQParam);

                        cmd.Prepare();
                        cmd.ExecuteNonQuery();
                    }

                    // Insert answers
                    foreach (var a in q.Answers) {
                        using (cmd = new SqlCommand()) {
                            cmd.Connection = Connection;
                            cmd.Transaction = transaction;
                            cmd.CommandText = @"INSERT INTO Answer VALUES (@Anwer_id, @Question_id, @Anwer, @is_true)";

                            var aIDParam = new SqlParameter("@Anwer_id", System.Data.SqlDbType.VarChar, 50);
                            var qIDParam = new SqlParameter("@Question_id", System.Data.SqlDbType.VarChar, 50);
                            var aAParam = new SqlParameter("@Anwer", System.Data.SqlDbType.NVarChar, 500);
                            var isTrueParam = new SqlParameter("@is_true", System.Data.SqlDbType.Bit);

                            aIDParam.Value = a.ID;
                            qIDParam.Value = a.QuestionID;
                            aAParam.Value = a.Content;
                            isTrueParam.Value = a.IsTrue;

                            cmd.Parameters.Add(aIDParam);
                            cmd.Parameters.Add(qIDParam);
                            cmd.Parameters.Add(aAParam);
                            cmd.Parameters.Add(isTrueParam);

                            cmd.Prepare();
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                transaction.Commit();
                return true;
            }
            catch (Exception e) {
                Console.WriteLine("Commit Exception Type: {0}", e.GetType());
                Console.WriteLine("  Message: {0}", e.Message);
                Console.WriteLine(e.StackTrace);
                MessageBox.Show("Xảy ra lỗi!");
                transaction.Rollback();

                return false;
            }

        }

        public static List<Subject> QuerySubjects(string teacherID) {
            List<Subject> list = new List<Subject>();

            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"select distinct sj.Subject_id, sj.Subject_name, sj.Credits from [Subject] as sj
                                join Classes as cls on cls.Subject_id = sj.Subject_id
                                where cls.Teacher_id = @id";

            var idParam = new SqlParameter("@id", System.Data.SqlDbType.VarChar, 50);
            idParam.Value = teacherID;

            cmd.Parameters.Add(idParam);
            cmd.Prepare();

            var reader = cmd.ExecuteReader();

            using (cmd)
            using (reader) {
                while (reader.Read()) {
                    string id = reader[0].ToString();
                    string name = reader[1].ToString();
                    int credits = Convert.ToInt32(reader[2]);
                    list.Add(new Subject(id, name, credits));
                }
            }

            return list;
        }

        public static void FillResultReportsBySubject(string teacherID, string subjectID, DateTime start, DateTime end, ReportClass report) {
            List<ResultReport> list = new List<ResultReport>();

            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"select distinct student.Student_id, student.Student_name, classes.Class_id, UPPER(classes.Subject_id) as Subject_id, results.Highest_score, results.Average_score, results.Times
                                from Students as student
                                join Student_Classes as student_classes on student_classes.Student_id = student.Student_id
                                join Classes as classes on student_classes.Class_id = classes.Class_id
                                join (
	                                select results.Student_id, MAX(results.Score) as Highest_score, AVG(results.Score) as Average_score, MAX(results.times) as Times
	                                from Student_Exam_Result as results
	                                group by results.Student_id
                                ) as results on results.Student_id = student.Student_id
                                join Exams as exams on classes.Class_id = exams.Class_id
                                where classes.Subject_id = @Subject_id AND classes.Teacher_id = @Teacher_id AND exams.Start_date >= @Start_date AND exams.Start_date <= @End_date";

            var idParam = new SqlParameter("@Teacher_id", System.Data.SqlDbType.VarChar, 50);
            var startDateParam = new SqlParameter("@Start_date", System.Data.SqlDbType.VarChar, 50);
            var endDateParam = new SqlParameter("@End_date", System.Data.SqlDbType.VarChar, 50);
            var subjectIDParam = new SqlParameter("@Subject_id", System.Data.SqlDbType.VarChar, 50);

            idParam.Value = teacherID;
            startDateParam.Value = start;
            endDateParam.Value = end;
            subjectIDParam.Value = subjectID;

            cmd.Parameters.Add(idParam);
            cmd.Parameters.Add(startDateParam);
            cmd.Parameters.Add(endDateParam);
            cmd.Parameters.Add(subjectIDParam);

            cmd.Prepare();

            using (cmd) {
                var table = new DataTable();
                var adapt = new SqlDataAdapter();
                adapt.SelectCommand = cmd;
                adapt.Fill(table);
                report.SetDataSource(table);
            }
        }

        public static void FillResultReportsByClass(string teacherID, string classID, DateTime start, DateTime end, ReportClass report) {
            List<ResultReport> list = new List<ResultReport>();

            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"select distinct student.Student_id, student.Student_name, classes.Class_id, UPPER(classes.Subject_id) as Subject_id, results.Highest_score, results.Average_score, results.Times
                                from Students as student
                                join Student_Classes as student_classes on student_classes.Student_id = student.Student_id
                                join Classes as classes on student_classes.Class_id = classes.Class_id
                                join (
	                                select results.Student_id, MAX(results.Score) as Highest_score, AVG(results.Score) as Average_score, MAX(results.times) as Times
	                                from Student_Exam_Result as results
	                                group by results.Student_id
                                ) as results on results.Student_id = student.Student_id
                                join Exams as exams on classes.Class_id = exams.Class_id
                                where classes.Class_id = @Class_id AND classes.Teacher_id = @Teacher_id AND exams.Start_date >= @Start_date AND exams.Start_date <= @End_date";

            var idParam = new SqlParameter("@Teacher_id", System.Data.SqlDbType.VarChar, 50);
            var startDateParam = new SqlParameter("@Start_date", System.Data.SqlDbType.VarChar, 50);
            var endDateParam = new SqlParameter("@End_date", System.Data.SqlDbType.VarChar, 50);
            var classIDParam = new SqlParameter("@Class_id", System.Data.SqlDbType.VarChar, 50);

            idParam.Value = teacherID;
            startDateParam.Value = start;
            endDateParam.Value = end;
            classIDParam.Value = classID;

            cmd.Parameters.Add(idParam);
            cmd.Parameters.Add(startDateParam);
            cmd.Parameters.Add(endDateParam);
            cmd.Parameters.Add(classIDParam);

            cmd.Prepare();

            using (cmd) {
                var table = new DataTable();
                var adapt = new SqlDataAdapter();
                adapt.SelectCommand = cmd;
                adapt.Fill(table);
                report.SetDataSource(table);
            }
        }

    }


}
