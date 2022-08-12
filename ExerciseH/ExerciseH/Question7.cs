using System;
namespace ExerciseH
{
    public class Question7
    {
        public static void MatrixMultiply(int[,] a, int[,] b)
        {
            int i, j;

            Console.WriteLine("Matrix a:");
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Matrix b:");
            for (i = 0; i < b.GetLength(0); i++)
            {
                for (j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            if (a.GetLength(1) != b.GetLength(0))
            {

                Console.WriteLine("Matrix multiplication not possible");
            }
            else
            {
                int[,] c = new int[a.GetLength(0), b.GetLength(1)];

                for (i = 0; i < a.GetLength(0); i++)
                {
                    for (j = 0; j < b.GetLength(1); j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < a.GetLength(1); k++)
                        {
                            c[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }
                Console.WriteLine("The product of the two matrices is :");
                for (i = 0; i < a.GetLength(0); i++)
                {
                    for (j = 0; j < b.GetLength(1); j++)
                    {
                        Console.Write(c[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
