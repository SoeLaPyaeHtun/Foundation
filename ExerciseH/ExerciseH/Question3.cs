using System;
namespace ExerciseH
{
    public class Question3
    {
        public static void SubString(string s, char a, char b)
        {
            string newString = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString().ToLower() == a.ToString().ToLower())
                {
                    newString = s.Replace(s[i], b);

                }

            }
            Console.WriteLine(newString);

        }

        
    }
}
