using System;

namespace exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine(
                    divide(
                        convertToInteger(getInput()),
                        convertToInteger(getInput())
                    )
                );
            } catch (DivideByZeroException e) {
                Console.WriteLine(e.Message);
                // throw;
            } catch (FormatException e) {
                Console.WriteLine(e.Message);
                // throw;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                // throw;
            } finally {
                Console.WriteLine("Done!!!");
            }
        }

        static double divide(double num1, double num2) { 
            return num1 / num2;
        }

        static double convertToInteger(string input) {
            return Convert.ToInt32(input);
        }

        static string getInput() {
            Console.Write("Enter a number: ");
            return Console.ReadLine();
        }
    }
}
