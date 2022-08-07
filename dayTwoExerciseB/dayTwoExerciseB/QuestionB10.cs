using System;
namespace dayTwoExerciseB
{
    public class QuestionB10
    {
        public static void BTen()
        {
            //qusestionB10
            Console.Write("length of A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("length of B: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.Write("length of C: ");
            double C = Convert.ToDouble(Console.ReadLine());
            if ((A + B) > C && (B + C) > A && (A + C) > B)
            {
                Console.Write($"Area Of Triangle is: {(A + B + C) / 2}");
            }
            else
            {
                Console.Write("Triangle does not exit with these side of lenghts");
            }
        }
    }
}
