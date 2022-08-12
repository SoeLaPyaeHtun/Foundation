using System;
namespace ExerciseH
{
    public class Question6
    {
        public static bool IsPrime(int n)
        {
            int factor_count = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    factor_count++;
                }

            }

            if (factor_count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
