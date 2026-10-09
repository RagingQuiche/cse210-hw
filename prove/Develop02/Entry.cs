using System;

public class Entry
{
    public string date;
    public string prompt;
    public string response;
    public string edits;
    public void DisplayEntry()
    {
        
    }
    public List<string> EditEntry(List<string> entry, string edits)
    {
        entry.Add(edits);
        return entry;
    }
    public List<string> WriteEntry(string date, string prompt, string response)
    {
        List<string> entry = new List<string>();
        entry.Add(date);
        entry.Add(prompt);
        entry.Add(response);
        return entry;
    }
};