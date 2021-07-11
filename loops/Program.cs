using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num = 0;
            Console.WriteLine("While Loop");
            WhileLoop(num);
            Console.WriteLine("Do While Loop");
            DoWhileLoop(num);
            Console.WriteLine("For Loop");
            ForLoop(10);
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

        static void ForLoop (int num) {
            int[] luckyNumbers = {4, 5, 6, 2, 10, 11};
            for (int i = 0; i < luckyNumbers.Length; i++) {
                Console.WriteLine(luckyNumbers[i]);
            }
        }
    }
}
