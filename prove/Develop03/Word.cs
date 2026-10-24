using System;

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word, bool isHidden)
    {
        _word = word;
        _isHidden = isHidden;
    }
    public void Hide()
    {
        _isHidden = true;
    }

    public string GetWord()
    {
        return _word;
    }

    public bool GetIfHidden()
    {
        return _isHidden;
    }

}