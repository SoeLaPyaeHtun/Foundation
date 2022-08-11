using System;
using System.Linq;

namespace ExerciseF
{
    public class Question5
    {


       

        public static void QFive()
        {

            String[] name = { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] mark = { 63, 29, 75, 82, 55 };

            //Unsorted
            var nameAndMark = name.Zip(mark, (n, m) => new { name = n, mark = m });

            foreach (var nnm in nameAndMark)
            {
                Console.WriteLine(nnm.name + "\t" + nnm.mark);
            }

            
            //Sorted Wth Name
            int temp;
            string something;
            for (int j = 0; j < name.Length - 1; j++)
            {
                for (int i = 0; i < name.Length - 1; i++)
                {

                   
                        if (Convert.ToInt32(name[i].ToLower()[0]) > Convert.ToInt32(name[i + 1].ToLower()[0]))
                        {
                            temp = mark[i + 1];
                            something = name[i + 1];
                            mark[i + 1] = mark[i];
                            name[i + 1] = name[i];
                            mark[i] = temp;
                            name[i] = something;

                        }else if(Convert.ToInt32(name[i].ToLower()[0]) == Convert.ToInt32(name[i + 1].ToLower()[0]))
                        {

                            for(int n = 1;n<name[i].Length;n++)
                        
                            {
                                if (Convert.ToInt32(name[i].ToLower()[n]) < Convert.ToInt32(name[i + 1].ToLower()[n]))
                                {
                                    temp = mark[i + 1];
                                    something = name[i + 1];
                                    mark[i + 1] = mark[i];
                                    name[i + 1] = name[i];
                                    mark[i] = temp;
                                    name[i] = something;

                                }
                                else if (Convert.ToInt32(name[i].ToLower()[n]) == Convert.ToInt32(name[i + 1].ToLower()[n]))
                                {
                                    continue;
                                }
                            }
                        }

                }
            }

            Console.WriteLine();
            Console.WriteLine("Sorted With Name");
            var sortedWithName = name.Zip(mark, (n, m) => new { name = n, mark = m });

            foreach (var swname in sortedWithName)
            {
                Console.WriteLine(swname.name + "\t" + swname.mark);
            }



            //Sorted With Mark
            for (int j = 0; j < mark.Length - 1; j++)
            {
                for (int i = 0; i < mark.Length - 1; i++)
                {
                    if (mark[i] > mark[i + 1])
                    {
                        temp = mark[i + 1];
                        something = name[i + 1];
                        mark[i + 1] = mark[i];
                        name[i + 1] = name[i];
                        mark[i] = temp;
                        name[i] = something;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Sorted With Name");
            var sortedWithMark = name.Zip(mark, (n, m) => new { name = n, mark = m });

            foreach (var swmark in sortedWithMark)
            {
                Console.WriteLine(swmark.name + "\t" + swmark.mark);
            }



        }
    }
}
