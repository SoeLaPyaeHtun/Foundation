using System;
namespace ExerciseH
{
    public class Question4
    {
        public static void SetArray(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = value;
            }
            foreach (var i in arr)
            {
                Console.Write(i);
            }
        }
    }
}
