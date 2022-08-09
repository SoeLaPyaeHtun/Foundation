using System;
namespace dayThreeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to ISS Gadget Shop\nNumber of items to purchase: ");
            double item = Convert.ToDouble(Console.ReadLine());
            double totalPrice = item * 500;
            if (totalPrice > 2000 && totalPrice <= 3000)
            {
                totalPrice = (totalPrice - (totalPrice * 0.03));
            }
            else if (totalPrice > 3000 && totalPrice <= 6000)
            {
                totalPrice = (totalPrice - (totalPrice * 0.05));
            }
            else if (totalPrice > 6000)
            {
                totalPrice = (totalPrice - (totalPrice * 0.08));
            }
            else
            {
                totalPrice *= 1;
            }
            Console.Write($"\nPlease pay ${totalPrice:#,0.00}");
        }
    }
}