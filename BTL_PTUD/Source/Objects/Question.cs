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

        public object Clone() {
            var q = new Question(ID, ExamID, Content);
            q.ID = null;
            foreach (var a in Answers) {
                var cloneA = (Answer)a.Clone();
                cloneA.ID = null;
                cloneA.QuestionID = null;
                q.Answers.Add(cloneA);
            }
            return q;
        }
    }

}
