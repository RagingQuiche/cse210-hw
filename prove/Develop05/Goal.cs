using System;
using System.ComponentModel;

public abstract class Goal
{
    protected string _title;
    protected string _description;
    protected int _points;

    public Goal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
    }

    public abstract void Display();
    
    public virtual string GetSaveString()
    {
        return $"{_title}, {_description}, {_points}";
    }
}