using System;
namespace ExerciseE
{
    public class Question3
    {
        public static void QThree()
        {
            Console.Write("Enter Number: ");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            int n = 0;

                for (int i = 1; i <= inputNum; i++)
                {
                    if (inputNum % i == 0)
                    {
                        n++;
                    }
                    i++;
                }
                if (n == 2)
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
