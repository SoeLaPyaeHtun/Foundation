using System;
using System.Linq;

namespace ExerciseE
{
    public class Question2
    {
        public static void QTwo()
        {
            Console.WriteLine($"\t NO \t INVERSE \t SQUAREROOT \t SQUARE");
            Console.WriteLine("\t" + String.Concat(Enumerable.Repeat("-", 48)));
            for (double i = 1; i <= 10; i++)
            {
                double inverse = 1 / i;
                double square_root = Math.Sqrt(i);
                double square = Math.Pow(i, 2);
                Console.WriteLine($"\t {i:0.0} \t {inverse:0.###} \t\t {square_root:0.###} \t\t  {square:0.0}");
            }
        }
    }
}
