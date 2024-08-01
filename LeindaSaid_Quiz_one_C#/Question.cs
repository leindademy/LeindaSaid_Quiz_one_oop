using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeindaSaid_Quiz_one_C_
{
    internal class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark { get; set; }

        public List<Answers> Answers;

        public Question()
        {

        }
        public Question(string header, string body, double mark, List<Answers> answers)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = new List<Answers>();
            Answers = answers;
        }
    }
}
