using System;
namespace ExerciseE
{
    public class Question6
    {
        public static void QSix()
        {
            Console.Write(" The perfect numbers from 1 to 1000 are: ");
            for (int num = 1; num <= 1000; num++)
            {
                int sumOfFactors = 0;

                for (int i = 1; i <= num - 1; i++)
                {
                    if (num % i == 0)
                    {
                        sumOfFactors += i;
                    }

                }

                if (sumOfFactors == num)
                {
                    Console.Write($"{sumOfFactors}  ");
                }

            }
        }
    }
}
