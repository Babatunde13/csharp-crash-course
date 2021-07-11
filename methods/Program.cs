using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Babatunde", 13);
            Console.WriteLine(cube(3));
        }

        // new method
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello "+ name);
            Console.WriteLine("You are "+ age);
        }

        static int cube(int num)
        {
            return num * num * num;
        }
    }
}
