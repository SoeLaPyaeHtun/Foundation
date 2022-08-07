using System;
namespace dayTwoExerciseB
{
    public class QuestionB9
    {
        public static void BNine()
        {
            //questionB9
            Console.Write("How many travalled in kilometer: ");
            double travalKilo = Convert.ToDouble(Console.ReadLine());
            double minFix = 2.4;
            if (travalKilo > 0)
            {
                double totalCharge = (travalKilo * 0.4) + 2.4;
                double result = (System.Math.Ceiling(totalCharge * 10) / 10);
                Console.Write($"the distance traveled is {travalKilo} km then the total fare is ${result}");
                
            }
            else
            {
                Console.Write($"Minimum fixed charge: {minFix}");
            }
        }
    }
}
