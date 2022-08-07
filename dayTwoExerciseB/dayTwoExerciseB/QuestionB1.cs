using System;
namespace dayTwoExerciseB
{
    public class QuestionB1
    {
        public static void BOne()
        {
            //questionB1
            Console.Write("Eneter a double precision number: ");
            double enterDouble = Convert.ToDouble(Console.ReadLine());
            double result = System.Math.Sqrt(enterDouble);
            Console.Write($"Output: {result:0.###}");
        }
    }
}
