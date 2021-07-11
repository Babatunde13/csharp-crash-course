using System;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello\nWorld!");
            string phrase = "Giraffe Academy";
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.Contains("Giraffe"));
            bool isMale = false;
            Console.WriteLine(isMale);

            // string indexing
            Console.WriteLine(phrase[2]);
            Console.WriteLine(phrase.IndexOf("Academy"));
            Console.WriteLine(phrase.IndexOf("d"));
            Console.WriteLine(phrase.IndexOf("z"));
            Console.WriteLine(phrase.Substring(8));
            Console.WriteLine(phrase.Substring(8, 6));
        }
    }
}
