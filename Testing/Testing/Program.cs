using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 6;
            Console.WriteLine("Main:" + x + "\t" + y);
            MethodOne(x, y);
            Console.WriteLine("Main" + x + "\t" + y);
        }

        static void MethodOne(int x, int y)
        {
            Console.WriteLine("Mthd:" + x + "\t" + y);
            x = 999; y = 333;
            Console.WriteLine("Mthd:" + x + "\t" + y);

        }
    }
}
