using System;
namespace ExerciseE
{
    public class Question5
    {
        public static void QFive()
        {
            for (int start = 5; start <= 10000; start++)
            {
                int n = 0;
                for (int i = 1; i <= start; i++)
                {
                    if (start % i == 0)
                    {
                        n++;

                    }

                }
                if (n == 2)
                {
                    Console.WriteLine(start);

                }

            }
        }
    }
}
