using System;
namespace ExerciseF
{
    public class Question4
    {
        public static void QFour()
        {
            Console.Write("Enter Pharse: ");
            String pharse = Console.ReadLine();
            string[] pharseWord = pharse.Split(" ");
            string[] output = new string[pharse.Length];
            for (int i = 0; i < pharseWord.Length; i++)
            {
                string a = pharseWord[i];
                string finished = char.ToUpper(a[0]) + pharseWord[i].Substring(1);
                output[i] = finished;

            }

            for (int j = 0; j < output.Length; j++)
            {
                Console.Write($"{output[j]} ");
            }
        }
    }
}
