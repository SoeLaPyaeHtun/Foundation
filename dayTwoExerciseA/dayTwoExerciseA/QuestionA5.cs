using System;
namespace dayTwoExerciseA
{
    public class QuestionA5
    {
        public static void AFive()
        {
            //questionA5
            Console.Write("Enter a double precision number: ");
            double enterDouble = Convert.ToDouble(Console.ReadLine());
            double result = (double)Math.Pow(enterDouble, 2);
            Console.Write($"The square of input number is {result:0.00}");
        }
    }
}
