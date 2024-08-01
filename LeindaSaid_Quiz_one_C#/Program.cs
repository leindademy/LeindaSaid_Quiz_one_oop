namespace LeindaSaid_Quiz_one_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            subject program = new subject(1, "programming");
            Console.WriteLine(" please choose between final the exam or Practical the exam");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {

                if (choice == 1) //Final the Exam
                {
                    program.AddExam();
                    program.ViewExam();
                }

                else if (choice == 2) //Practical the exam
                {
                    program.AddExam();
                    program.ViewExam();
                }
            }
        }
    }
}
