using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What's your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What's you favorite number? ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    static void PromptUserBirthYear(ref int birthYear)
    {
        Console.Write("What is your birthyear? ");
        string input = Console.ReadLine();
        birthYear = int.Parse(input);
    }
    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }
    static void DisplayResult(string name, int squaredNumber, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
        Console.WriteLine($"{name}, you will turn {2026 - birthYear} this year.");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int birthYear = 2026;
        PromptUserBirthYear(ref birthYear);
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber, birthYear);

    }
}