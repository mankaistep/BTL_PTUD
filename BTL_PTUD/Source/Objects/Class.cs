using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTUD.Source.Objects {
    class Class {

        public readonly string ID;
        public readonly string TeacherID;
        public readonly string Name;
        public readonly string SubjectID;

        public Class(string id, string teacherID, string name, string subjectID) {
            ID = id;
            TeacherID = teacherID;
            Name = name;
            SubjectID = subjectID;
        }
    }
}
