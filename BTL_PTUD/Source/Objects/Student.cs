using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTUD.Source.Objects {

    class Student {

        public readonly string ID;
        public readonly string Name;
        public readonly DateTime Date;
        public readonly string Department;

        public Student(string id, string name, DateTime date, string department) {
            this.ID = id;
            this.Name = name;
            this.Date = date;
            this.Department = department;
        }


    }

}
