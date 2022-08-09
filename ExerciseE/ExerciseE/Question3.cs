using System;
namespace ExerciseE
{
    public class Question3
    {
        public static void QThree()
        {
            Console.Write("Enter Number: ");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            int factor_count = 0;

                for (int i = 1; i <= inputNum; i++)
                {
                    if (inputNum % i == 0)
                    {
                    factor_count++;
                    }
                   
                }

                if (factor_count == 2)
                {
                    Console.WriteLine("Input Number is a Prime Number");
                }
                else
                {
                    Console.WriteLine("Input Number is not a Prime Number");
                }

            
        }
    }
}
