using System;

namespace dayTwoQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length in cm: ");
            double inputCm = Convert.ToDouble(Console.ReadLine());
            double outputInch = inputCm / 2.54;
            Console.Write($"Input length in inch: {outputInch:0.000}");

        }
    }
}
