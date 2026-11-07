using System;

public class Question
{
    private List<string> _questions;

    public Question(List<string> questions)
    {
        _questions = questions;
    }

    public List<string> GetList()
    {
        return _questions;
    }
}