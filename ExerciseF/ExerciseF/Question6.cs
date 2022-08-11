using System;
namespace ExerciseF
{
    public class Question6
    {
        public static void QSix()
        {
            Console.Write("Enter a matriculation number: ");
            string input = Console.ReadLine();
            int Multi = 6;
            int result = 0;
           
            for(int i =1; i <= 5; i++)
            {
                
                result += Convert.ToInt32(input[i].ToString()) * Multi;
                Multi--;
            }


            if (input.Length == 7)
            {
                if (result % 5 == 0 && input[6].ToString() == "O" )
                {
                    Console.Write("Valid");
                }
                else if (result % 5 == 1 && input[6].ToString() == "P")
                {
                    Console.Write("valid");
                }
                else if (result % 5 == 2 && input[6].ToString() == "Q")
                {
                    Console.Write("valid");
                }
                else if (result % 5 == 3 && input[6].ToString() == "R")
                {
                    Console.Write("valid");
                }
                else if (result % 5 == 4 && input[6].ToString() == "S")
                {
                    Console.Write("valid");
                }
                else
                {
                    Console.Write("Invalid");
                }


            }
            else
            {
                Console.Write("Invalid");
            }


        }
    }
}
