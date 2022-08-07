using System;
namespace dayTwoExerciseB
{
    public class QuestionB7
    {
        public static void BSeven()
        {
            //questionB7
            Console.Write("How many travalled in kilometer: ");
            double travalKilo = Convert.ToDouble(Console.ReadLine());
            double minFix = 2.4;
            if (travalKilo > 0)
            {
                double totalCharge = (travalKilo * 0.4) + minFix;
                Console.Write($"the distance traveled is {travalKilo} km then the total fare is ${totalCharge:0.###}");
            }
            else
            {
                Console.Write($"Minimum fixed charge: ${minFix}");
            }
        }
    }
}
