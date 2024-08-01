using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeindaSaid_Quiz_one_C_
{
    internal class Exam
    {
        public double Time { get; set; }

        public int Number_Of_Questions { get; set; }
        public double Marks { get; set; } = 0;
        public subject Subject { get; set; }

        public List<Question> Questions { get; set; }

        public Exam(double time, int numberofquestion,subject subject, List<Question> questions)
        {
            Time = time;
            Number_Of_Questions = numberofquestion;
            Subject =  subject;
            Questions = new List<Question>();
        }
        public void TrueOrFalse()
        {
            for (int i = 0; i < Number_Of_Questions; i++)
            {
                Console.WriteLine("Please enter the header");
                string header = Console.ReadLine();

                Console.WriteLine("Please enter the question");
                string question = Console.ReadLine();

                Console.WriteLine("Please enter the answer");
                string answer = Console.ReadLine();

                Console.WriteLine("Please enter the mark");
                double mark = Convert.ToDouble(Console.ReadLine());

                Answers result = new Answers(1, answer);
                true_or_false True_Or_False = new true_or_false(header, question, mark, new List<Answers> { result });
                Questions.Add(True_Or_False);
            }
        }
        public void Mcq()
        {
            Console.WriteLine("Please enter the question");
            string body = Console.ReadLine();
            Console.WriteLine("Please enter the mark");
            if (double.TryParse(Console.ReadLine(), out double mark))
            {
                Mcq mcq = new Mcq();

                mcq.options = new List<string>();

                Console.WriteLine("Enter the options of the question");

                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Enter the choice");

                    string questionchoices = Console.ReadLine();

                    mcq.options.Add(questionchoices);
                }
                mcq.Body = body;
                mcq.Mark = mark;
                Console.WriteLine("Enter the answer of the question");

                string answer = Console.ReadLine();

                Answers valid_answer = new Answers(0, answer);

                mcq.answer = valid_answer.Text;

                this.Questions.Add(mcq);
            }
        }
    }
}





