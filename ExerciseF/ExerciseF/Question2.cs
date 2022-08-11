using System;
using System.Linq;

namespace ExerciseF
{
    public class Question2
    {
        public static void QTwo()
        {
            Console.Write("Enter Word: ");
            string word = Console.ReadLine();
            int count = 0;
           

            for (int i = 0; i < word.Length; i++)
            {
                if(word[i].ToString() == word[word.Length - (i + 1)].ToString())
                {
                    count++;
                }
            }
            if(count == word.Length)
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
