using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTUD.Source.Objects {
    public class Exam {

        public string ID;
        public string TeacherID;
        public string ClassID;
        public DateTime CreationDate;
        public int Time;
        public string ExamOrder;
        public DateTime StartDate;
        public DateTime EndDate;
        public int Limit;
        public int NumberQuestion;

        public List<Question> Questions { get; set; }

        public Exam(string teacherID) {
            TeacherID = teacherID;
            CreationDate = DateTime.Now;
            StartDate = DateTime.Now;
            EndDate = DateTime.Now.AddDays(365);
            Time = 0;
            Limit = 0;
            NumberQuestion = 0;
            Questions = new List<Question>();
        }

        public Exam(string id, string teacherID, string classID, DateTime creationDate, int time, string examOrder, DateTime startDate, DateTime endDate, int limit, int numberQuestion) {
            ID = id;
            TeacherID = teacherID;
            ClassID = classID;
            CreationDate = creationDate;
            Time = time;
            ExamOrder = examOrder;
            StartDate = startDate;
            EndDate = endDate;
            Limit = limit;
            NumberQuestion = numberQuestion;
            Questions = new List<Question>();
        }

        public bool CanEdit() {
            return DateTime.Compare(StartDate, DateTime.Now) > 0;
        }

    }
}
