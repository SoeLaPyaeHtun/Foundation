using System;
namespace dayTwoExerciseB
{
    public class QuestionB5
    {
        public static void BFive()
        {
            //questionB5
            Console.Write("Enter a Number: ");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            int result = (5 * (inputNum * inputNum)) - (4 * inputNum) + 3;
            Console.Write("Result: "+result);
        }
    }
}
