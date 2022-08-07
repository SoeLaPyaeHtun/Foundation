using System;
namespace dayTwoExerciseB
{
    public class QuestionB3
    {
        public static void BThree()
        {
            //questionB3
            Console.Write("Enter Basic Salary: ");
            int enterSalary = Convert.ToInt32(Console.ReadLine());
            int housingAllowance = (enterSalary * 10) / 100;
            int transportAllowance = (enterSalary * 3) / 100;
            int totalIncome = enterSalary + housingAllowance + transportAllowance;
            Console.Write($"Basic Salary plus benefits: ${totalIncome:00.00}");
        }
    }
}
