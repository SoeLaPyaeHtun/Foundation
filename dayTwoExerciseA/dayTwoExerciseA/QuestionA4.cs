using System;
namespace dayTwoExerciseA
{
    public class QuestionA4
    {
        public static void AFour()
        {
            //questionA4
            Console.Write("Enter a double precision number: ");
            double enterDouble = Convert.ToDouble(Console.ReadLine());
            double result = (double)Math.Pow(enterDouble, 2);
            Console.Write($"The square of input number is {result}");
        }
}
}
