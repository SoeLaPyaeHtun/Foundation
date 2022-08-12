using System;
using System.Linq;
namespace ExerciseG
{
    public class Question3
    {
        public static void QThree()
        {
            
            int[,] rollAndMark = new int[,]
            {  { 1,56, 84, 68, 29 },
               { 2,94, 73, 31, 96 },
               { 3,41, 63, 36, 90 },
               { 4,99, 9, 18, 17 },
               { 5,62, 3, 65, 75 },
               { 6,40, 96, 53, 23 },
               { 7,81, 15, 27, 30 },
               { 8,21, 70, 100, 22 },
               { 9,88, 50, 13, 12 },
               { 10,48, 54, 52, 78 },
               { 11,64, 71, 67, 25 },
               { 12,16, 93, 46, 72 }
            };
            Console.WriteLine($"Subjet1\t\tSubject2\tSubject3\tSubject4\tTotal\tAverage\t");
            for (int i = 0; i < rollAndMark.GetLength(0); i++)
            {
                double total = 0;


                double average = 0.00;

                for (int j = 1; j < rollAndMark.GetLength(1); j++)
                {
                    Console.Write(+rollAndMark[i, j] + " \t\t");
                    total += (Convert.ToInt32(rollAndMark[i, j]));

                }



                Console.Write(total);
                average = total / 4;
                Console.Write("\t" + average);
                Console.WriteLine();

            }


            //Average per subject
            Console.WriteLine();
            Console.WriteLine("Average Per Subject: ");
           
            for (int m = 1; m < 5; m++)

            {
                double subAverage = 0.0;
                for (int n = 0; n < rollAndMark.GetLength(0); n++)
                {

                    subAverage += (Convert.ToInt32(rollAndMark[n, m]));

                }
                Console.WriteLine($"Subject{m}'s average is {subAverage/12:0.#####}");
            }
        }
    }
}