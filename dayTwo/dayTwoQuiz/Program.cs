using System;

namespace dayTwoQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length in cm: ");
            double enterValue = Convert.ToDouble(Console.ReadLine());
            Console.Write($"{enterValue / 2.54:0.000}");

        }
    }
}

