using System;
namespace ExerciseE
{
    public class Question1A
    {
        public static void QOneA()
        {
            Console.Write("Enter Number(increment): ");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;

            for (int n = 1; n <= num; n++)
            {
                fact = fact * n;
                if(n < num)
                {
                    Console.Write($"{n} * ");
                }
                else
                {
                    Console.Write($"{n} = ");
                }
            }
            Console.WriteLine($"{fact}");
        }
    }
}
