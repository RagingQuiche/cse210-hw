using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        int magicNumber = randomGenerator.Next(1, 100);

        Console.Write("What is the magic numer? ");

        int correct = 0;
        do
        {
            string input = Console.ReadLine();
            int guess = int.Parse(input);

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
                Console.Write("What's your new guess? ");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
                Console.Write("What's your new guess? ");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (correct != 1);
    }
}