using System;
namespace DailyQuiz4
{
    class Program
    {
        static void Main(string[] args)
        {
            //VALIDATION WITH STRING

            int count = 0;
            Console.WriteLine("Welcome to the Bank of ISS");
            while (true)
            {
                Console.Write("Enter your PIN: ");
                string inputNumber = Console.ReadLine();
                Console.WriteLine("");
                if (inputNumber == "123456")
                {
                    Console.Write("PIN accepted. You can access your account now.");
                    break;
                }
                else
                {
                    count++;
                }
                if (count == 3)
                {
                    Console.Write("Too many wrong PIN entries. Your account is now locked.");
                    break;
                }
                Console.WriteLine("Incorrect PIN. Please try again.");
            }


            //VALIDATION WITH INTEGER

            //int count = 0;
            //Console.WriteLine("Welcome to the Bank of ISS");
            //while (true)
            //{
            //    Console.Write("Enter your PIN: ");
            //    int inputNumber = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("");
            //    if (inputNumber == 123456)
            //    {
            //        Console.Write("PIN accepted. You can access your account now.");
            //        break;
            //    }
            //    else
            //    {
            //        count++;
            //    }
            //    if (count == 3)
            //    {
            //        Console.Write("Too many wrong PIN entries. Your account is now locked.");
            //        break;
            //    }
            //    Console.WriteLine("Incorrect PIN. Please try again.");
            //}

        }
    }
}