using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
                string playAgain = "yes";
        Random random = new Random();

        while (playAgain.ToLower() == "yes")
        {
            int magicNumber = random.Next(1, 101); // Random number from 1 to 100
            int guess = 0;
            int guessCount = 0;

            Console.WriteLine("I'm thinking of a number between 1 and 100...");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out guess))
                {
                    guessCount++;

                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                        Console.WriteLine($"It took you {guessCount} guesses.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}