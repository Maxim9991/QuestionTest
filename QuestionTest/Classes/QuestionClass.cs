using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionTest.Classes
{
    public class QuestionClass
    {
        public string Text { get; set; }
        public List<QuestionAnswerClass> questionAnswerClasses { get; set; }
    }

    public class QuestionAnswerClass
    {
        public string Text { get; set; }
        public bool IsTrue { get; set; }
    }
}
