using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string _edits;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine($"Edits: {_edits}");
    }
};