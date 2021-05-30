﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTUD.Source.Objects {
    class Exam {

        public readonly string ID;
        public string TeacherID;
        public string ClassID;
        public DateTime CreationDate;
        public long Time;
        public string ExamOrder;
        public DateTime StartDate;
        public DateTime EndDate;
        public int Limit;
        public List<Question> Questions;

        public Exam(string id, string teacherID, string classID, DateTime creationDate, long time, string examOrder, DateTime startDate, DateTime endDate, int limit, List<Question> questions) {
            ID = id;
            TeacherID = teacherID;
            ClassID = classID;
            CreationDate = creationDate;
            Time = time;
            ExamOrder = examOrder;
            StartDate = startDate;
            EndDate = endDate;
            Limit = limit;
            Questions = questions;
        }
    }
}