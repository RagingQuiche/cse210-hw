using System;

public class ChecklistGoal : Goal
{
    private int _progress;
    private int _end;
    public ChecklistGoal(string title, string description, int points, int end, int progress=0) : base (title, description, points)
    {
        _progress = progress;
        _end = end;
    }

    public override void Display()
    {
        Console.WriteLine($"{_title}: {_description}. Points: {_points}. Completed: {_progress}/{_end}.");
    }

    public override string GetSaveString()
    {
        return $"{_title}, {_description}, {_points}, {_progress}, {_end}";
    }

    public void CompleteInstance()
    {
        if (_progress < _end)
        {
            _progress += 1;
        }
    }

    public int GetProgress()
    {
        return _progress;
    }

    public int GetGoal()
    {
        return _end;
    }
}