using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTUD.Source.Objects {
    class Teacher {

        public readonly string ID;
        public readonly string Name;
        public readonly string Department;
        public readonly string Mail;

        public Teacher(string id, string name, string department, string mail) {
            ID = id;
            Name = name;
            Department = department;
            Mail = mail;
        }

    }
}
