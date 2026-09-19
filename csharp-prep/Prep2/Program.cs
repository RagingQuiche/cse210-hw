using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade percentage? ");
        string input = Console.ReadLine();
        float gradePercentage = float.Parse(input);

        string letterGrade;
        bool passFail = true;

        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }    
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
            passFail = false;
        }
        else
        {
            letterGrade = "F";
            passFail = false;
        }


        if (passFail == true)
        {
            Console.WriteLine($"You passed! Your letter grade is {letterGrade}.");
        }
        else
        {
            Console.WriteLine($"Your letter grade is {letterGrade}. Hopefully you can do better next time.");
        }
        }   
}