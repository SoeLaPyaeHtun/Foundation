using System;
using System.Linq;

namespace ExerciseG
{
    public class Question2
    {
      

        public static void QTwo()
        {
            //Unsorted Array
            int[] array = { 12, 45, 84, 43, 2, 0, 11};
            Console.Write("Unsorted Array ==> ");
            foreach (var n in array)
            {
                Console.Write($"{n} ");

            }
            Console.WriteLine();
            Console.WriteLine();


            //Sorting
            for (var i = 0; i < array.Length - 1; i++)
            {
                var minKey = i;
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[minKey])
                    {
                        minKey = j;
                    }
                }

                //swap
                var temp = array[i];
                array[i] = array[minKey];
                array[minKey] = temp;

                Console.Write($"step {i+1} ==> ");
                foreach (var m in array)
                {
                    Console.Write($"{m} ");
                  
                }
                Console.WriteLine();
                Console.WriteLine();

            }


            //Sorted Array
            Console.Write("Sorted Array ==> ");
            foreach (var m in array)
            {
                Console.Write($"{m} ");

            }


        }

        
    }
}
