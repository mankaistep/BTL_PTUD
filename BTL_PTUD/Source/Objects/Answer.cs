using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTUD.Source.Objects {
    public class Answer {

        public readonly string ID;
        public readonly string QuestionID;
        public string Content;
        public bool IsTrue;

        public Answer(string id, string questionID, string content, bool isTrue) {
            this.ID = id;
            this.QuestionID = questionID;
            this.Content = content;
            this.IsTrue = isTrue;
        }

    }
}
