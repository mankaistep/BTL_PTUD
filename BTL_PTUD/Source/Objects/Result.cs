using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTUD.Source.Objects {
    public class Result {

        public readonly string ID;
        public readonly string StudentID;
        public readonly string ExamID;
        public readonly float Score;
        public readonly DateTime Date;

        // Minutes
        public readonly int AccessTime;
        public readonly int Times;

        public string StudentName;

        public Result(string iD, string studentID, string examID, float score, DateTime date, int accessTime, int times) {
            ID = iD;
            StudentID = studentID;
            ExamID = examID;
            Score = score;
            Date = date;
            AccessTime = accessTime;
            Times = times;
        }
    }
}
