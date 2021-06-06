using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTUD.Source.Objects {
    public class Teacher {

        public readonly string ID;
        public readonly string Name;
        public readonly string SubjectID;
        public readonly string Department;
        public readonly string Mail;

        public Teacher(string id, string name, string subjectID, string department, string mail) {
            ID = id;
            Name = name;
            SubjectID = subjectID;
            Department = department;
            Mail = mail;
        }

    }
}
