using System;

public class EternalGoal : Goal
{
    public EternalGoal(string title, string description, int points) : base (title, description, points)
    {
        
    }

    public override void Display()
    {
        Console.WriteLine($"{_title}: {_description}. Points: {_points}.");
    }

    public override string GetSaveString()
    {
        return base.GetSaveString();
    }
}