using BTL_PTUD.Source.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTUD.Source.Connection {

    class SQLConnections {

        public static SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-S4GU3GQ\SQLEXPRESS;Initial Catalog=phanmemthi;Integrated Security=SSPI");

        public static void Init(string s) {
            Connection = new SqlConnection();
            Connection.ConnectionString = s;
            Connection.Open();
        }

        public static int QueryCurrentExamAmount() {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"SELECT COUNT(*) FROM Exams WHERE Start_date <= GETDATE() AND End_date >= GETDATE()";
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
                    long time = Convert.ToInt64(reader[2].ToString());
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
                    choice.Answer = QueryAnswer(choice.AnswerID).Content;
                }
            }

            return list;
        }

    }
}
