using System;

namespace conditionals {
    class Program  {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            bool isMale = false;
            bool isTall = false;
            CheckIfMaleAndTall(isMale, isTall);
            Console.WriteLine(getMaximum(121, 12, 4));
        }

        static void CheckIfMaleAndTall(bool isMale, bool isTall) {
            if (isMale && isTall) {
                Console.WriteLine("You are a tall male!");
            } else if(isMale && !isTall) {
                Console.WriteLine("You are a short male!");
            } else if (!isMale && isTall) {
                Console.WriteLine("You are a tall female!");
            } else {
                Console.WriteLine("You are a short female!");
            }
            // or
            if (isMale || isTall) {
                Console.WriteLine("You are eiter a male or tall!");
            } else {
                Console.WriteLine("You are a short female!");
            }
            Console.WriteLine(Convert.ToBoolean("false"));
        }

        static int getMaximum(int num1, int num2, int num3) {
            if (num1 == num2 || num1 == num3 || num2 == num3) {
                return 0;
            }
            if (num1 > num2) {
                if (num1 > num3) return num1;
                else return num3;
            } else if (num2 > num1) {
                if (num2 > num3) return num2;
                else return num3;
            } else {
                if (num3 > num1) return num3;
                return num1;
            }
        }
    }
}
