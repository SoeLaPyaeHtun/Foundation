using System;
namespace dayTwoExerciseC
{
    public class QuestionC5V2
    {
        public static void CFiveVTwo(int n)
        {
            //questionc5
            Console.Write("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int toCompare = num;
            int plus = 0;
            
            while (num > 0)
            {
                num = num / 10;
                n++;
            }
            

            while (num > 0)
            {
         
                int div = num % 10;
                
                plus += (int)Math.Pow(div, n);
                

                num = num / 10;
                Console.WriteLine(plus);

            }
            Console.WriteLine(plus);

            if (toCompare == plus)
            {
                Console.WriteLine("True");
                Console.WriteLine(plus);
            }
            else
            {
                Console.WriteLine("Flase");
                Console.WriteLine(plus);
            }
        }
    }
}
