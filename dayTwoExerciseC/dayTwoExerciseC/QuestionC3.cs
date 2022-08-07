using System;
namespace dayTwoExerciseC
{
    public class QuestionC3
    {
        public static void CThree()
        {
            //questionc3
            Console.Write("Enter Your Mark: ");
            int mark = Convert.ToInt32(Console.ReadLine());
            if (100 >= mark && mark >= 80)
            {
                Console.WriteLine($"You scored {mark} marks which is A grade.");
            }
            else if (80 > mark && mark >= 60)
            {
                Console.WriteLine($"You scored {mark} marks which is B grade.");
            }
            else if (60 > mark && mark >= 40)
            {
                Console.WriteLine($"You scored {mark} marks which is C grade.");
            }
            else if (40 > mark && mark >= 0)
            {
                Console.WriteLine($"You scored {mark} marks which is F grade.");
            }
            else
            {
                Console.WriteLine($"** ERROR **");
            }
            
        }
    }
}
