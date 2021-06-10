using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTUD.Source.Objects {
    class ResultReport {

        public string StudentID;
        public string StudentName;
        public string ClassID;
        public string SubjectID;
        public double HighestScore;
        public double AverageScore;
        public int Times;

        public ResultReport(string studentID, string studentName, string classID, string subjectID, double highestScore, double averageScore, int times) {
            StudentID = studentID;
            StudentName = studentName;
            ClassID = classID;
            SubjectID = subjectID;
            HighestScore = highestScore;
            AverageScore = averageScore;
            Times = times;
        }
    }
}
