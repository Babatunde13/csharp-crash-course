using System;

namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Guess("heyy!");
        }

        static void Guess(string secretWord) {
            Console.Write("Enter a guess:  ");
            string guess = Console.ReadLine();
            int guessCount = 1;
            int guessLimit = 5;
            while (guess != secretWord && guessCount < guessLimit) {
                int remainingTrials = guessLimit - guessCount;
                Console.WriteLine("You have "+ remainingTrials+ " left");
                Console.Write("Enter a guess:  ");
                guess = Console.ReadLine();
                guessCount++;
            }
            if (secretWord == guess) Console.WriteLine("You Win");
            else Console.WriteLine("Oops1, You Loose");
        }
    }
}
