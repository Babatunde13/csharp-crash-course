using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num = 0;
            WhileLoop(num);
            Console.WriteLine("");
            DoWhileLoop(num);
        }

        static void WhileLoop (int num) {
            while(num < 5) {
                Console.WriteLine(num);
                num++;
            }
        }

        static void DoWhileLoop (int num) {
            num = 6;
            do {
                Console.WriteLine(num);
                num++;
            } while(num < 5);
        }
    }
}
