using System;

namespace ExerciseH
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1.StrToInt();


            //int[] s = { 1231, 232, 324, 546 };
            //Question2.PrintArray(s);

            //Question3.SubString("apple", 'p', 'a');


            //int[] nothing = new int[10];
            //Question4.SetArray(nothing, 4);



            //int[] str = new int[10] { 12,23,34,234,234,34,234,234,34,234};
            //Question5.ResizeArray(str, 15);


            //Question Six
            //Console.WriteLine("prime number from 5 to 1000 : ");
            //for (int start = 5; start <= 100; start++)
            //{
            //    if (Question6.IsPrime(start))
            //    {
            //        Console.Write($"{start} ");
            //    }


            //}


            int[,] a = new int[4, 2] { { 3, 4 }, { 0, 0 }, { 7, 8 }, { 0, 0 } };
            int[,] b = new int[2, 3] { { 0, 2, 4 }, { 0, 7, 4 } };
            Question7.MatrixMultiply(a, b);

           

        }
    }
}
