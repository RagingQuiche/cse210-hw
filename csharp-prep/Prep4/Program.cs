using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); 
        
        int item = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (item != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            item = int.Parse(input);
            numbers.Add(item);
        }

        int sum = 0;
        int largest = 0;
        foreach (int number in numbers)
        {
            sum += number;
            if (number > largest)
            {
                largest = number;
            }
        }

        float average = 0;
        if (numbers.Count != 1)
        {
            average = (float)sum / (numbers.Count - 1);
        }
       
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}