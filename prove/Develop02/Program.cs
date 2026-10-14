using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        journal._entries = new List<Entry>();
        journal.LoadFromFile();
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Display Journal Entries");
            Console.WriteLine("2. Add a New Entry");
            Console.WriteLine("3. Edit an Existing Entry");
            Console.WriteLine("4. Save Your Changes");
            Console.WriteLine("0. Exit");
            Console.Write("Your choice: ");
            string input = Console.ReadLine();
            int indicator = int.Parse(input);
            switch (indicator)
            {
                case 0:
                    isRunning = false;
                    break;
                case 1:
                    journal.DisplayEntries();
                    break;
                case 2:
                    journal.AddEntry();
                    break;
                case 3:
                    journal.EditEntries();
                    break;
                case 4:
                    journal.SaveToFile();
                    break;
            }
        }
    }
}