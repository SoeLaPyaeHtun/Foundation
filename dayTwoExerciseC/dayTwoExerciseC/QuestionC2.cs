using System;
namespace dayTwoExerciseC
{
    public class QuestionC2
    {
        public static void CTwo()
        {
            //questionc2
            Console.Write("Enter Your Name: ");
            String name = Console.ReadLine();
            Console.Write("What is Gender (Type Male for M and Female For F): ");
            String gender = Console.ReadLine();
            Console.Write("Enter Age: ");
            String age = Console.ReadLine();
            int toAge = Convert.ToInt32(age);
            if (gender == "M" && toAge < 40)
            {
                Console.WriteLine($"\tGood Morning Mr. {name}");
            }
            else if (gender == "F" && toAge < 40)
            {
                Console.WriteLine($"\tGood Morning Mrs. {name}");
            }
            else if (gender == "M" && toAge >= 40)
            {
                Console.WriteLine($"\tGood Morning Uncle {name}");
            }
            else if (gender == "F" && toAge >= 40)
            {
                Console.WriteLine($"\tGood Morning Aunty {name}");
            }
            else
            {
                Console.Write("Please Type Correctly!");
            }
        }
    }
}
