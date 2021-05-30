using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTUD.Source.Objects {

    class Question {

        public readonly string ID;
        public string Content;
        public List<Answer> Answers;

        public Question(string id, string content, List<Answer> answers) {
            this.ID = id;
            this.Content = content;
            this.Answers = answers;
        }

    }

}
