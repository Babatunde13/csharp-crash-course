using System;

namespace calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operation, +, -, * /:  ");
            string op = Console.ReadLine();
            
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Calculate(num1, num2, op);

            Console.WriteLine(getDay(10));
        }

        static void Calculate(double num1, double num2, string op) {
            if (op == "+") Console.WriteLine( num1 + num2 );
            else if (op == "-") Console.WriteLine( num1 - num2 );
            else if(op == "*") Console.WriteLine( num1 * num2 );
            else if(op == "/") Console.WriteLine( num1 / num2 );
            else Console.WriteLine( "Invalid operation!!!" );
        }

        static string getDay(int dayNum) {
            switch (dayNum)
            {
                case 0 :
                    return "sunday";
                case 1:
                    return "monday";
                case 2:
                    return "tuesday";
                case 3:
                    return "wednesday";
                case 4:
                    return "thursday";
                case 5:
                    return "friday";
                case 6:
                    return "saturday";
                default:
                    return "Invalid day number";
            }
        }
    }
}
