using System;
namespace dayTwoExerciseA
{
    public class QuestionA3
    {
        public static void AThree()
        {
            //questionA3
            Console.Write("Eneter a integer number: ");
            int enterInt = Convert.ToInt32(value: Console.ReadLine());
            int result = (int)Math.Pow(enterInt, 2);
            Console.Write($"The square of input number is {result}.");
        }
    }
}
