using System;
namespace ExerciseD
{
    public class question3b
    {
        public static void QThreeB()
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
                    if (n <= 2)
                    {
                        Console.Write("\"You are a Wizard!\"");
                    }
                    else if (n > 2 && n <= 5)
                    {
                        Console.Write("\"You are a good guess!\"");
                    }
                    else
                    {
                        Console.Write("\"You are lousy!\"");
                    }
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
