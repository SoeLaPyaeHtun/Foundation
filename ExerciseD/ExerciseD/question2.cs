using System;
namespace ExerciseD
{
    public class question2
    {
        public static void QTwo()
        {
            Console.Write("Number A: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number B: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            int A = firstNum;
            int B = secondNum;

            if (B > A)
            {
                while (B > A)
                {
                    B -= A;
                    if (A > B)
                    {
                        A -= B;
                    }
                }
            }
            else
            {
                while (A > B)
                {
                    A -= B;
                    if (B > A)
                    {
                        B -= A;
                    }
                }
            }
            Console.WriteLine($"HCF: {A}");
            int lcm = firstNum * secondNum / A;
            Console.WriteLine($"LCM: {lcm}");
        }
    }
}
