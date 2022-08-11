using System;
namespace ExerciseF
{
    public class Question3
    {
        public static void QThree()
        {
            Console.Write("Enter Pharse: ");
            String inputPharse = Console.ReadLine().ToLower();
            char[] specialChar = { ',', '!', '-', ' ', '@', '*', '&', '#', '.' };
            string[] result = inputPharse.Split(specialChar);
            string word = string.Join("", result);
            int count = 0;


            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].ToString() == word[word.Length - (i + 1)].ToString())
                {
                    count++;
                }
            }
            if (count == word.Length)
            {
                Console.Write("Input word is palindrome");
            }
            else
            {
                Console.Write("Input word is not palindrome");
            }

        }
    }
}


