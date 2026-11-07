using System;
using System.Runtime.CompilerServices;

public class ReflectionActivity : Activity
{
    private List<Question> _questionList;

    public ReflectionActivity(string name, string description, int duration, List<Question> questionList) : base (name, description, duration)
    {
        _questionList = questionList;
    }

    public int PickIndex()
    {
        Random random = new Random();
        return random.Next(0, _questionList.Count());
    }

    public void DisplayNextQuestion(int question, int index)
    {
        List<string> questions = _questionList[question].GetList();
        Console.Write(questions[index]);
    }
}