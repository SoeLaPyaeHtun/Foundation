using System;
namespace ExerciseF
{
    public class Question1A
    {
        public static void QOneA()
        {
            Console.Write("Enter Pharse: ");
            string pharse = Console.ReadLine().ToLower();
            string[] toComp = { "a", "e", "i", "o", "u" };
            int count = 0;
            for (int i = 0; i < pharse.Length; i++)
            {
                for (int j = 0; j < toComp.Length; j++)
                {
                    if (toComp[j].ToString() == pharse[i].ToString())
                    {
                        count++;
                    }
                }

            }
            Console.Write(count + " vowels in pharse that you entered.");
        }
    }
}

