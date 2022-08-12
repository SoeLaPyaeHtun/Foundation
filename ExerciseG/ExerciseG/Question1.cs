using System;
using System.Linq;

namespace ExerciseG
{
    public class Question1
    {
        public static void QOne()
        {
            int[] monthly_record = { 12, 43, 42, 25, 100, 75, 34, 23, 43, 23, 45, 99 };
            int monthly_record_min = monthly_record.Min();
            int monthly_record_max = monthly_record.Max();
            Console.WriteLine(monthly_record_max);
            Console.WriteLine(Array.IndexOf(monthly_record ,monthly_record_max));
            Console.WriteLine(monthly_record_min);
            Console.WriteLine(Array.IndexOf(monthly_record ,monthly_record_min));


            int total = 0;
            for(int i = 0; i < monthly_record.Length; i++)
            {
                total += monthly_record[i];    
            }

            double average = total / 2;

            Console.WriteLine(average);

        }
    }
}
