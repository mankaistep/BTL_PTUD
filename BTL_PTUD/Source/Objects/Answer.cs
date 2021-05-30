using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTUD.Source.Objects {
    class Answer {

        public readonly string ID;
        public string Content;
        public bool IsTrue;

        public Answer(string id, string content, bool isTrue) {
            this.ID = id;
            this.Content = content;
            this.IsTrue = isTrue;
        }

    }
}
