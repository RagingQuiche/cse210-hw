using System;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _responseNum;

    public ListingActivity(string name, string description, int duration, List<string> prompts, int responseNum) : base (name, description, duration)
    {
        _prompts = prompts;
        _responseNum = responseNum;
    }

    public void DisplayPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count());
        Console.WriteLine(_prompts[index]);
    }

    public void RecordResponse()
    {
        string reply = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(reply) && !string.IsNullOrEmpty(reply))
        {
            _responseNum++;
        }
        Console.WriteLine();
    }

    public int GetResponseNum()
    {
        return _responseNum;
    }

    public void SetResponseNum(int responses=0)
    {
        _responseNum = responses;
    }
}