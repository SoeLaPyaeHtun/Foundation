using System;
namespace ExerciseD
{
    public class question1
    {
        public static void QOne()
        {
            while (true)
            {
                Console.Write("Enter Number: ");
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                if (inputNumber == 88)
                {
                    Console.Write("\t\"Lucky You\"");
                    break;
                }
                else
                {
                    Console.WriteLine("\"Try Again\"");
                }
            }
        }
    }
}
