using System;
namespace dayTwoExerciseC
{
    public class QuestionC1
    {
        public static void COne()
        {
            //questionc1
            Console.Write("Enter Your Name: ");
            String name = Console.ReadLine();
            Console.Write("What is Gender (Type Male for M and Female For F): ");
            String gender = Console.ReadLine();
            if (gender == "M")
            {
                Console.WriteLine($"\tGood Morning Mr. {name} \n where you entered {name} for name and {gender} for gender.");
            }
            else if (gender == "F")
            {
                Console.WriteLine($"\tGood Morning Mrs. {name} \n where you entered {name} for name and {gender} for gender.");
            }
            else
            {
                Console.Write("Please Type Correctly!");
            }
        }
    }
}
