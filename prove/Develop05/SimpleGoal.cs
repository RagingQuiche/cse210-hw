using System;

public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string title, string description, int points, bool completed=false) : base (title, description, points)
    {
        _completed = completed;
    }

    public override void Display()
    {
        string marker = " ";
        if (_completed)
        {
            marker = "X";
        }
        Console.WriteLine($"{_title}: {_description}. Points: {_points}. Completed: [{marker}]");
    }

    public void SetCompleted()
    {
        _completed = true;
    }

    public bool GetIfCompleted()
    {
        return _completed;
    }
    public override string GetSaveString()
    {
        return $"{_title}, {_description}, {_points}, {_completed}";
    }
}