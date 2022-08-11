using System;
namespace ExerciseF
{
    public class Question1B
    {
        public static void QOneB()
        {
            int count_A = 0;
            int count_E = 0;
            int count_I = 0;
            int count_O = 0;
            int count_U = 0;

            Console.Write("Enter Pharse: ");
            string pharse = Console.ReadLine().ToLower();
            string[] toComp = { "a", "e", "i", "o", "u" };

            for (int i = 0; i < pharse.Length; i++)
            {
                for (int j = 0; j < toComp.Length; j++)
                {
                    if (toComp[j].ToString() == pharse[i].ToString())
                    {
                        if (pharse[i] == 'a')
                        {
                            count_A++;
                        }
                        else if (pharse[i] == 'e')
                        {
                            count_E++;
                        }
                        else if (pharse[i] == 'i')
                        {
                            count_I++;
                        }
                        else if (pharse[i] == 'o')
                        {
                            count_O++;
                        }
                        else if (pharse[i] == 'u')
                        {
                            count_U++;
                        }
                    }
           

                }
            }
            Console.Write($"In pharse that you entered\nNumber of vowal a(A) is {count_A}\nNumber of vowal e(E) is {count_E}\nNumber of vowal i(I) is {count_I}\nNumber of vowal o(O) is {count_O}\nNumber of vowal u(U) is {count_U}");

                
            

        }
    }

}
