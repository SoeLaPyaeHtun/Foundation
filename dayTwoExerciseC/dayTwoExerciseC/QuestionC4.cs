using System;
namespace dayTwoExerciseC
{
    public class QuestionC4
    {
        public static void CFour()
        {
            //questionc4
            Console.Write("The distance travelled is: ");
            double disTravelled = Math.Round(Convert.ToDouble(Console.ReadLine()), 1, MidpointRounding.ToPositiveInfinity);
            if (disTravelled > 9.0)
            {
                double km2m = disTravelled * 10;
                double result = 2.4 + 85 * (0.04) + (km2m - 90) * 0.05;
                Console.WriteLine(result);
            }
            else if (disTravelled <= 0.5)
            {
                double result = 2.4;
                Console.WriteLine(result);
            }
            else
            {
                double km2m = disTravelled * 10;
                double result = 2.4 + (km2m - 5) * (0.04);
                Console.WriteLine(result);
            }
        }
    }
}
