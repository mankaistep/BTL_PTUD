using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTUD.Source.Objects {

    public class Question {

        public string ID;
        public string ExamID;
        public string Content;
        public List<Answer> Answers { get; set; }

        public Question(string id, string examID, string content) {
            this.ID = id;
            this.ExamID = examID;
            this.Content = content;

            Answers = new List<Answer>();
        }

    }

}
