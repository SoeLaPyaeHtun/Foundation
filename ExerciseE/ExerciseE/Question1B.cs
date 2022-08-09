using System;
namespace ExerciseE
{
    public class Question1B
    {
        public static void QOneB()
        {
            Console.Write("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int n = num; n >= 1; n--)
            {
                fact = fact * n;
            }
            Console.Write($"Factorial of Input Number: {fact}");
        }
    }
}
