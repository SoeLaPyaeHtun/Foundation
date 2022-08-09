using System;
namespace ExerciseD
{
    public class question3a
    {
        public static void QthreeA()
        {
            Random rnd = new Random();
            int ramdomNum = rnd.Next(0, 9);
            int n = 0;
            while (true)
            {
                n++;
                Console.Write("Enter Guess Number: ");
                int guessNum = Convert.ToInt32(Console.ReadLine());
                if (guessNum == ramdomNum)
                {
                    Console.WriteLine("congratulate");
                    Console.WriteLine($"attempts {n}");
                   
                    break;
                }
                else
                {
                    Console.WriteLine("Try Again");

                }

            }

        }
    }
}
