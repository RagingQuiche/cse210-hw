using System;
using System.ComponentModel;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public int GetTime()
    {
        return _duration;
    }

    public void ShowPrologue()
    {
        Console.WriteLine($"Welcome to the {_name}. {_description}. It will last for {_duration} seconds.");
    }

    public void ShowEpilogue()
    {
        Console.Write($"Thank you for participating in the {_name}. You'll be taken back to the menu now. ");
    }

    public void ShowSpinner()
    {
        for (int i = 0; i < 6; i++)
        {
            Console.Write("_");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("o");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("O");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("0");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("O");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("o");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    public void CountDown(int time)
    {
        for (int second = time; second >= 0; second--)     
        {
            Console.Write(second);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
    }

    public int GetDuration()
    {
        return _duration;
    }
}