using System;
namespace ExerciseE
{
    public class Question4
    {
        public static void QFive()
        {
            Console.Write("Enter Number");
            int Input = Convert.ToInt32(Console.ReadLine());
            int toComp = Input;
            int result = 0;
            for (int i = 1; i <= Input - 1; i++)
            {
                if (Input % i == 0)
                {
                    result += i;
                }
            }

            if (result == toComp)
            {
                Console.Write("This is perfect");
            }
            else
            {
                Console.Write("This is not perfect");
            }
        }
    }
}
