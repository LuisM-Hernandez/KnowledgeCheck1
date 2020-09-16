using System;

namespace KnowledgeCheck1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter grade point average");
            double userGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter test score");
            double userScore = Convert.ToDouble(Console.ReadLine());

            if (userGrade >= 3.0 && userScore >= 60)
            {
                Console.WriteLine("Accept");
            }

            else if (userGrade <= 3.0 && userScore >= 80)
            {
                Console.WriteLine("Accept");
            }

            else if (userGrade <= 3.0 || userScore <= 60)
            {
                Console.WriteLine("Reject");
            }

            else if (userGrade <= 3.0 && userScore <= 80)

            {
                Console.WriteLine("Reject");
            }

        
        }
    }
}
