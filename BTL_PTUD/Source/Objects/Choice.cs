using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTUD.Source.Objects {
    public class Choice {

        public readonly string ID;
        public readonly string ResultID;
        public readonly string AnswerID;
        public readonly string QuestionID;

        public string Question;
        public string Answer;
        public bool IsTrue;

        public Choice(string id, string resultID, string answerID, string questionID) {
            ID = id;
            ResultID = resultID;
            AnswerID = answerID;
            QuestionID = questionID;
        }
    }
}
