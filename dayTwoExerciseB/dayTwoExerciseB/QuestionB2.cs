using System;
namespace dayTwoExerciseB
{
    public class QuestionB2
    {
        public static void BTwo()
        {
            //questionB2
            Console.Write("Eneter a double precision number: ");
            double enterDouble = Convert.ToDouble(Console.ReadLine());
            double result = System.Math.Sqrt(enterDouble);
            Console.Write($"Output: {result:0.000}");
        }
    }
}
