using System;
namespace ExerciseH
{
    public class Question5
    {
        public static void ResizeArray(int[] arr, int newSize)
        {
            Console.WriteLine($"Original Array Length: {arr.Length}");
            foreach(var i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Array.Resize(ref arr, newSize);
            Console.WriteLine($"New Array Length {arr.Length}");
            foreach (var n in arr)
            {
                Console.Write($"{n} ");
            }
        }
    }
}
