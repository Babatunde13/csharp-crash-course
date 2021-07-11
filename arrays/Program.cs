using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] luckyNumbers = {4, 8, 16, 12, 23, 42};
            string[] names ={"babatunde", "john"};
            Console.WriteLine(luckyNumbers[0]);
            luckyNumbers[0] = 1000;
            Console.WriteLine(luckyNumbers[0]);
            string [] friends = new string[5];
            friends[0] = "100";
            friends[1] = "200";
            friends[2] = "300";
            friends[3] = "400";
            friends[4] = "500";
            Console.WriteLine(friends);
            Console.WriteLine(numbrGrid());
        }
        
        static int[,] numbrGrid () {
            int [,] array = {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };
            int [,] unknownArray = new int [2, 3];
            return array;
        }
    }
}