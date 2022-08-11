using System;
namespace ExerciseE
{
    public class Question4
    {
        public static void QFour()
        {
            Console.Write("Enter Number: ");
            int inputNum = Convert.ToInt32(Console.ReadLine());

           
            int sumOfFactors = 0;

            for (int i = 1; i < inputNum; i++)
            {
                if (inputNum % i == 0)
                {
                    sumOfFactors += i;
                }
            }

            if (sumOfFactors == inputNum)
            {
                Console.Write("This is a perfect number");
            }
            else
            {
                Console.Write("This is not a perfect number");
            }
        }
    }
}
