using System;
namespace dayTwoExerciseB
{
    public class QuestionB8
    {
        public static void BEight()
        {
            //questionB8
            Console.Write("How many travalled in kilometer: ");
            double travalKilo = Convert.ToDouble(Console.ReadLine());
            double minFix = 2.4;
            if (travalKilo > 0)
            {
                double totalCharge = (travalKilo * 0.4) + minFix;
                double result = System.Math.Round(totalCharge, 1);
                Console.Write($"the distance traveled is {travalKilo} km then the total fare is ${result:#.00}");
            }
            else
            {
                Console.Write($"Minimum fixed charge: {minFix:#.00}");
            }
        }
    }
}
