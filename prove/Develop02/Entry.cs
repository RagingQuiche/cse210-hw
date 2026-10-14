using System;

public class Entry
{
    public string _date { get; set; }
    public string _prompt { get; set; }
    public string _response { get; set; }
    public string _edits {get; set;}

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine($"Edits: {_edits}");
    }
};