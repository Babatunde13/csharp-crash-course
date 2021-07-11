using System;

namespace calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Enter a number:  ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number:  ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = num1+num2;
            Console.WriteLine("The sum of " + num1 + " and " + num2 +" is "+ sum);

        }
    }
}
