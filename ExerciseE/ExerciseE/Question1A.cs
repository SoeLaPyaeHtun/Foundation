using System;
namespace ExerciseE
{
    public class Question1A
    {
        public static void QOneA()
        {
            Console.Write("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int n = 1; n <= num; n++)
            {
                fact = fact * n;
            }
            Console.Write($"Factorial of Input Number: {fact}");
        }
    }
}
