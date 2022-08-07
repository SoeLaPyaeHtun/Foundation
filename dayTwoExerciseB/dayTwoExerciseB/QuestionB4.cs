using System;
namespace dayTwoExerciseB
{
    public class QuestionB4
    {
        public static void BFour()
        {
            //questionB4
            Console.Write("Temperature in Centigrade(C): ");
            int inputCent = Convert.ToInt32(Console.ReadLine());
            int outputFahrenheit = (int)((inputCent * 1.8) + 32);
            Console.Write("Temperature in Fahrenheit (F): " + outputFahrenheit);
        }
    }
}
