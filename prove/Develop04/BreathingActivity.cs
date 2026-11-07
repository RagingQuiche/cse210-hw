using System;
using System.ComponentModel;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base (name, description, duration)
    {
        
    }

    public void BreatheIn()
    {
        Console.Write("Breathe in... ");
        base.CountDown(4);
        Console.WriteLine();
    }

    public void BreatheOut()
    {
        Console.Write("Breathe out... ");
        base.CountDown(8);
        Console.WriteLine();
    }
}