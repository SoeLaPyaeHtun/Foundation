using System;
namespace ExerciseH
{
    public class Question1
    {
        public static void StrToInt()
        {
            while (true)
            {
                Console.Write("Enter Pharse: ");
                string s = Console.ReadLine();

                try
                {
                    Console.Write($"Yep!! This is number {Convert.ToInt32(s)}");
                    break;
                }
                catch
                {
                    Console.WriteLine("Pharse that you entered is not number.......");
                }

            }
        }
    }
}
