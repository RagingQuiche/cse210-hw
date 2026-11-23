using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goalList = new List<Goal>();
        bool isRunning = true;
        while (isRunning)
        {
            string switchString = Console.ReadLine();
            int input = int.Parse(switchString);
            Console.WriteLine("");
            string title = Console.ReadLine();
            Console.WriteLine("");
            string description = Console.ReadLine();
            Console.WriteLine("");
            string pointString = Console.ReadLine();
            int points = int.Parse(pointString);
            switch (input)
            {
                case 1:
                    SimpleGoal simpleGoal = new SimpleGoal(title, description, points);
                    goalList.Add(simpleGoal);
                    break;
                case 2:
                    EternalGoal eternalGoal = new EternalGoal(title, description, points);
                    goalList.Add(eternalGoal);
                    break;
                case 3:
                    Console.WriteLine("");
                    string endString = Console.ReadLine();
                    int end = int.Parse(endString);
                    ChecklistGoal checklistGoal = new ChecklistGoal(title, description, points, end);
                    goalList.Add(checklistGoal);
                    break;
            }
        }
        


    }
}