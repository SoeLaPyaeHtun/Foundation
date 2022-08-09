using System;
namespace ExerciseE
{
    public class Question5
    {
        public static void QFive()
        {
            for (int start = 5; start <= 100; start++)
            {
                int factor_count = 0;
                for (int i = 1; i <= start; i++)
                {
                    if (start % i == 0)
                    {
                        factor_count++;

                    }

                }
                if (factor_count == 2)
                {
                    Console.WriteLine(start);

                }

            }
        }
    }
}
