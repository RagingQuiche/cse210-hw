    using System;

    class Program
    {
        static void Main(string[] args)
        {
            List<Goal> goalList = new List<Goal>();
            string filePath = "GoalSave.csv";
            int totalPoints = 0;

            bool isRunning = true;
            while (isRunning)
            {   
                Console.Write("Menu:\n    1. Make a new goal\n    2. Save goals\n    3. Load saved goals\n    4. Update progress\n    5. Display goals\n    6. Display earned points\n    7. Exit\nResponse: ");
                string switchString1 = Console.ReadLine();
                int input1 = int.Parse(switchString1);
                switch (input1)
                {
                    case 1:
                        Console.Write("What type of goal do you want to make?\n    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal\nResponse: ");
                        string switchString2 = Console.ReadLine();
                        int input2 = int.Parse(switchString2);
                        Console.Write("What is your goal? ");
                        string title = Console.ReadLine();
                        Console.Write("Describe your goal: ");
                        string description = Console.ReadLine();
                        Console.Write("How many points will you earn for it? ");
                        string pointString = Console.ReadLine();
                        int points = int.Parse(pointString);
                        switch (input2)
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
                                Console.Write("How many times do you want to complete this goal? ");
                                string endString = Console.ReadLine();
                                int end = int.Parse(endString);
                                Console.WriteLine("You'll receive double the points for the final time completing the goal.");
                                ChecklistGoal checklistGoal = new ChecklistGoal(title, description, points, end);
                                goalList.Add(checklistGoal);
                                break;
                        }
                        break;
                    case 2:
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.WriteLine(totalPoints);
                            foreach (Goal goal in goalList)
                            {
                                writer.WriteLine(goal.GetSaveString());
                            }
                        }
                        Console.WriteLine("Save complete.");
                        break;
                    case 3:
                        using (StreamReader reader = new StreamReader(filePath))
                        {
                            string line;
                            goalList.Clear();
                            string loadPointString = reader.ReadLine();
                            int loadTotalPoints = int.Parse(loadPointString);
                            totalPoints = loadTotalPoints;
                            while ((line = reader.ReadLine()) != null)
                            {
                                string[] parts = line.Split(',');
                                int loadPoints = int.Parse(parts[2]);
                                if (parts.Length == 3)
                                {
                                    EternalGoal eternalGoal = new EternalGoal(parts[0], parts[1], loadPoints);
                                    goalList.Add(eternalGoal);
                                }
                                else if (parts.Length == 4)
                                {
                                    bool loadCompleted = bool.Parse(parts[3]);
                                    SimpleGoal simpleGoal = new SimpleGoal(parts[0], parts[1], loadPoints, loadCompleted);
                                    goalList.Add(simpleGoal);
                                }
                                else if (parts.Length == 5)
                                {
                                    int loadProgress = int.Parse(parts[3]);
                                    int loadEnd = int.Parse(parts[4]);
                                    ChecklistGoal checklistGoal = new ChecklistGoal(parts[0], parts[1], loadPoints, loadEnd, loadProgress);
                                    goalList.Add(checklistGoal);
                                }
                            }
                        }
                        Console.WriteLine("Load complete.");
                        break;
                    case 4:
                        Console.WriteLine("Here are the goals you've made:");
                        int i = 1;
                        foreach (Goal goal in goalList)
                        {
                            Console.Write($"{i}. ");
                            goal.Display();
                            i++;
                        }
                        Console.Write("Which goal did you accomplish? (Enter number): ");
                        string accomplishedString = Console.ReadLine();
                        int accomplished = int.Parse(accomplishedString);
                        Goal updateGoal = goalList[accomplished - 1];
                        totalPoints += updateGoal.GetPoints();
                        if (updateGoal is SimpleGoal simple)
                        {
                            if (simple.GetIfCompleted())
                            {
                                totalPoints -= simple.GetPoints();
                            }
                            simple.SetCompleted();
                        }
                        else if (updateGoal is ChecklistGoal checklist)
                        {
                            if (checklist.GetProgress() >= checklist.GetGoal())
                            {
                                totalPoints -= checklist.GetPoints();
                            }    
                            checklist.CompleteOnce();
                        }
                        Console.WriteLine($"Updated.\nYour point total is {totalPoints}.");
                        break;
                    case 5:
                        Console.WriteLine("These are your current goals: ");
                        int j = 1;
                        foreach (Goal goal in goalList)
                        {
                            Console.Write($"{j}. ");
                            goal.Display();
                            j++;
                        }
                        break;
                    case 6:
                        Console.WriteLine($"Your current score is {totalPoints}.");
                        break;
                    case 7:
                        isRunning = false;
                        Console.WriteLine("Exiting....");
                        break;
                }        
            }
        }
    }