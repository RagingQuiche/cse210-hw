using System;
using System.Text.Json;
public class Journal
{
    public List<Entry> _entries;
    Random random = new Random();
    public List<string> Prompts { get; set; } = ["What was the most impactful thing someone said to you today?",
                                    "If you could go back in time one week, what would you do?",
                                    "Who do you miss the most right now?",
                                    "Who is your closest friend right now?",
                                    "What are you currently learning?",
                                    "What have you put your trust in today?",
                                    "How has your load been lightened?",
                                    "Did you find an opportunity to serve others today? Did you take it?",
                                    "What's your message for the world right now?",
                                    "IF you had a two week vacation starting tomorrow, where would it be?",
                                    "What's your favorite piece of media lately, and why?",
                                    "What's your ideal Christmas/birthday present? (whichever is coming next)"];

    public void AddEntry()
    {
        Entry entry = new Entry();
        Console.Write("What is the date? ");
        entry._date = Console.ReadLine();
        entry._prompt = SelectPrompt();
        Console.Write($"Prompt: {entry._prompt} ");
        entry._response = Console.ReadLine();
        entry._edits = "";
        _entries.Add(entry);    
    }

    public void DisplayEntries()
    {
        int entryCount = 1;
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Entry {entryCount}:");
            entry.DisplayEntry();
            entryCount++;
        }
    }

    public void EditEntries()
    {
        Console.Write("What is the index of the entry you want to edit? ");
        string input = Console.ReadLine();
        int index = int.Parse(input);
        Entry entry = _entries[index - 1];
        Console.Write("Entry: ");
        entry.DisplayEntry();
        Console.Write("Enter your edits here: ");
        entry._edits = Console.ReadLine();
    }

    public string SelectPrompt()
    {
        string prompt = Prompts[random.Next(Prompts.Count)];
        return prompt;
    }

    public void LoadFromFile()
    {
        string filePath = "entries.json";
        if (File.Exists(filePath) && new FileInfo(filePath).Length > 0)
        {
            string jsonString = File.ReadAllText(filePath);
            _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
        }
    }

    public void SaveToFile()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        File.WriteAllText(Path.Combine(AppContext.BaseDirectory, "entries.json"), JsonSerializer.Serialize(_entries, options));
    }
}