using System;

namespace DemoDayOne
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double b = 6.7 * 2;
            string MyName = "David";
            double c = 6143.21683;
            double d = 007.3422;

            DemoDayOne.ProjectTwo.inClass();
            Console.WriteLine("NUS \t World!");
            Console.WriteLine($"a = {b}");
            Console.WriteLine($"My name is {MyName}");
            Console.WriteLine($"{c}");
            Console.WriteLine($"{c:#.#}");
            Console.WriteLine($"{d:###.##}");

            Console.Write("Enter Your Name ");
            string name = Console.ReadLine();
            Console.WriteLine($"Your name is {name}");

            Console.Write("Please Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number + 1);
            Console.Write("The End");


        }
    }
}
