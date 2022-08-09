using System;
namespace dayTwoExerciseC
{
    public class QuestionC5
    {
        public static void CFive()
        {
            //questionc5
            Console.Write("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int toCompare = num;
            int plus = 0;
            while (num > 0)
            {
                int div = num % 10;
                plus += div * div * div;

                num = num / 10;

            }
            if (toCompare == plus)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("Flase");
            }
        }
    }
}