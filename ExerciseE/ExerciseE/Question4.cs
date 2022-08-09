using System;
namespace ExerciseE
{
    public class Question4
    {
        public static void QFour()
        {
            Console.Write("Enter Number: ");
            int Input = Convert.ToInt32(Console.ReadLine());

            int toComp = Input;

            int result = 0;

            for (int i = 1; i < Input; i++)
            {
                if (Input % i == 0)
                {
                    result += i;
                }
            }

            if (result == toComp)
            {
                Console.Write("This is a perfect number");
            }
            else
            {
                Console.Write("This is not a perfect number");
            }
        }
    }
}
