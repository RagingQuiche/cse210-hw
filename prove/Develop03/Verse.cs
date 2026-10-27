using System;

public class Verse
{
    private List<Word> _wordList = [];

    public Verse(List<Word> wordList)
    {
        _wordList = wordList;
    }

    public List<Word> GetList()
    {
        return _wordList;
    }

    public void DisplayVerse()
    {
        string sentence = "";
        foreach (Word current in _wordList)
        {
            string word = current.GetWord();
            word = word.Replace(" ", string.Empty);
            bool hidden = current.GetIfHidden();
            string blanks = "";
            if (hidden == true)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    blanks += "_";
                }
                sentence += $"{blanks} ";
                blanks = "";
            }
            else
            {
                sentence += $"{word} ";
            }
        }
        Console.WriteLine(sentence);
    }

    public void HideWords(int numHidden=3)
    {   
        List<int> indecesNotHidden = new List<int>();
        Random random = new Random();
        for (int i = _wordList.Count() - 1; i >= 0; i--)
        {
            Word word = _wordList[i];
            bool hidden = word.GetIfHidden();
            if (!int.TryParse(word.GetWord(), out int number))
                if (hidden == false)
                {
                    indecesNotHidden.Add(i);
                }
        }
        if (numHidden <= indecesNotHidden.Count())
        {
            for (int j = 0; j < numHidden; j++)
            {
                int index = random.Next(0, indecesNotHidden.Count());
                int targetIndex = indecesNotHidden[index];
                _wordList[targetIndex].Hide();
                indecesNotHidden.RemoveAt(index);
            }
        }
        else
        {
            for (int k = 0; k < indecesNotHidden.Count(); k++)
            {
                int index = random.Next(0, indecesNotHidden.Count());
                int targetIndex = indecesNotHidden[index];
                _wordList[targetIndex].Hide();
                indecesNotHidden.RemoveAt(index);
            }
        }    
    }
}