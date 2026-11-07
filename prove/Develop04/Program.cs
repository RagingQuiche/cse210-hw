using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> question1 = ["Think of a time that you did something difficult.", "How did you feel before and after you did it?", "What was the outcome?", "Was it a desireable outcome?"];
        Question question = new Question(question1);
        List<Question> questionList = [question];
        List<string> prompts = ["What are you grateful for today?", "What are you looking forward to right now?", "Who are the people in your support system right now?"];
        
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Welcome to the mindfulness app. Please select an activity.\n1. Breathing Activity\n2. Reflecting Activity\n3. Listing Activity\n4. Exit");
            Console.Write("Enter 1-4: ");
            string switchString = Console.ReadLine();
            int input = int.Parse(switchString);
            if (input <= 0 || input > 4)
            {
                Console.WriteLine("Please enter a valid input.");
                Thread.Sleep(1000);
                Console.Clear();
                break;
            }
            int time = 0;
            if (input != 4)
            {
                Console.Write("How long do you want to do the activity in seconds? ");
                string inputTime = Console.ReadLine();
                time = int.Parse(inputTime);
            }    
            int elapsed = 0;
            Console.Clear();

            switch (input)
            {
                case 1:
                   BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "Breathe in and out with the messages that appear", time);
                   breathingActivity.ShowPrologue();
                   while (elapsed < time)
                    {
                        breathingActivity.BreatheIn();
                        breathingActivity.BreatheOut();
                        elapsed += 10;
                    }
                    breathingActivity.ShowEpilogue();
                    breathingActivity.ShowSpinner();
                    Console.Clear();
                   break;
                case 2:
                    ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "You will be given a question to reflect on and take time to ponder follow-up questions", time, questionList);
                    reflectionActivity.ShowPrologue();
                    int index = reflectionActivity.PickIndex();
                    reflectionActivity.DisplayNextQuestion(index, 0);
                    Console.WriteLine();
                    Console.Write("Press 'enter' when you're ready to reflect");
                    Console.ReadLine();
                    for (int i = 1; i < 4; i++)
                    {
                        reflectionActivity.DisplayNextQuestion(index, i);
                        reflectionActivity.CountDown(time / 3);
                        Console.WriteLine();
                    }
                    reflectionActivity.ShowEpilogue();
                    reflectionActivity.ShowSpinner();
                    Console.Clear();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity("Listing Activity", "You will list your thoughts relating to the prompt", time, prompts, 0);
                    listingActivity.ShowPrologue();
                    listingActivity.DisplayPrompt();
                    Console.WriteLine("Press 'enter' when you're ready to start listing");
                    Console.ReadLine();
                    while (elapsed < time)
                    {
                        int startTime = Environment.TickCount;
                        listingActivity.GetResponseNum();
                        elapsed += (Environment.TickCount - startTime) / 1000;
                    }
                    listingActivity.ShowEpilogue();
                    listingActivity.ShowSpinner();
                    Console.Clear();
                    break;
                case 4:
                    Console.Write("Exiting. ");
                    Activity a = new Activity("a", "b", 0);
                    a.ShowSpinner();
                    isRunning = false;
                    break;
            }
        }
    }
}