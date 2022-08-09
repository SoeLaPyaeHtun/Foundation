using System;
namespace ExerciseE
{
    public class Question6
    {
        public static void QSix()
        {
            for (int start = 1; start <= 1000; start++)
            {
                int result = 0;
                int toComp = start;
                for (int i = 1; i <= start - 1; i++)
                {
                    if (start % i == 0)
                    {
                        result += i;
                    }

                }
                if (result == toComp)
                {
                    Console.WriteLine($"This is perfect: {result}");
                }

            }
        }
    }
}
