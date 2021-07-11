using System;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(-40, 4));
            Console.WriteLine(Math.Max(-40, 4));

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello  "+ name + ", you are " + age + " years old.");
        }
    }
}
