using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countyContest.Win.DataModel
{
    internal class Question
    {
        public string question;
        public string answer;
        public AnswerType answerType;

        public Question(string question, string answer, AnswerType answerType)
        {
            this.question = question;
            this.answer = answer;
            this.answerType = answerType;
        }
    }
}