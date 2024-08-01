using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeindaSaid_Quiz_one_C_
{
    internal class subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam Exam { get; set; }

        public subject(int id, string name)
        {
            Id = id;
            Name = name;

        }
        /// Create A New Exam
        public void InitializeExam(double time, int numberofquestion, int choice)
        {
            //for (int i = 0; i < numberofquestion; i++)
            //{
            //    Console.WriteLine("Please enter the question");
            //    string question = Console.ReadLine();
            //    Console.WriteLine("Please enter the answer");
            //    string answer = Console.ReadLine();
            //    Console.WriteLine("Please enter the mark");
            //    double mark = Convert.ToDouble(Console.ReadLine());
            //    Answers result = new Answers(1, answer);
            //    true_or_false True_Or_False = new true_or_false(question, answer, mark, new List<Answers> { result });
            //    Exam.Questions.Add(True_Or_False);
            //}

            Exam = new Exam(time, numberofquestion, this, new List<Question>());
            if (choice == 1)
            {
                Exam.TrueOrFalse();
            }
            else if (choice == 2)
            {
                Exam.Mcq();
            }

        }

        public void AddExam()
        {
            Console.WriteLine("please Choose between True or False or MCQ ?");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice == 1) // True Or False 
                {
                    Console.WriteLine("what is Time of exam ?");
                    if (double.TryParse(Console.ReadLine(), out double Time))
                    {
                        Console.WriteLine("please enter aNumber of questions in exam ? ");
                        if (int.TryParse(Console.ReadLine(), out int numberofquestion))
                        {
                            InitializeExam(Time, numberofquestion, choice);
                        }
                        else
                        {
                            Console.WriteLine("Please enter another value ?");
                        }
                    }

                }
                else if (choice == 2) // MCQ
                    Console.WriteLine("Time of exam");
                if (double.TryParse(Console.ReadLine(), out double time))
                {
                    Console.WriteLine("Number of questions in exam ");
                    if (int.TryParse(Console.ReadLine(), out int numberofquestion))
                    {
                        InitializeExam(time, numberofquestion, choice);
                    }
                    else
                    {
                        Console.WriteLine("Please enter another value ?");
                    }
                }

            }
            else
            {
                Console.WriteLine("Please enter another value ?"); 
            }


        }
        public void ViewExam()
        {
            for (int i = 0; i < Exam.Questions.Count; i++)
            {
                if (this.Exam.Questions[i] is true_or_false)
                {
                    true_or_false true_or_false = (true_or_false)Exam.Questions[i];
                    Console.WriteLine("Please enter the answer of the question:");
                    Console.WriteLine("True or False \n");
                    string answer = Console.ReadLine();
                    if (answer == this.Exam.Questions[i].Answers[0].Text)
                    {
                        this.Exam.Marks += this.Exam.Questions[i].Mark;
                    }
                }
                else
                {
                    Mcq mcq = (Mcq)Exam.Questions[i];
                    string body = Exam.Questions[i].Body;
                    Console.WriteLine(body);
                    Console.WriteLine("Please enter the answer of the question:");
                    string answer = Console.ReadLine();
                    if (answer == mcq.answer)
                    {
                        Exam.Marks += Exam.Questions[i].Mark;
                    }
                }
            }
            Console.WriteLine($"Your have scored : {Exam.Marks} marks !");
        }
    }
}

