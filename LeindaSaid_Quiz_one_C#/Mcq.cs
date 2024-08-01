using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeindaSaid_Quiz_one_C_
{
    internal class Mcq:Question
    {
        public List<string> options;
        public string answer;
        public Mcq()
        {

        }
        public Mcq(string Header,string Body, double Mark, List<Answers> Answers) : base(Header, Body, Mark,Answers)
        {
            
        }
    }
}
