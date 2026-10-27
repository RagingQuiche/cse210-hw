using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("James", 4, 17);

        string scripture = """
17 Therefore to him that knoweth to do good, and doeth it not, to him it is sin.
""";
        string[] words = scripture.Split();
        //Separates the scripture string to put each into its own word
        List<Word> verse = [];
        
        foreach (string j in words)
        {
            Word word = new Word(j, false);
            verse.Add(word);
        }
        Verse allVerses = new Verse(verse);
        
        reference.DisplayRef();
        allVerses.DisplayVerse();
        
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Please type the number of words you'd like to hide, or press enter to hide 3. Type 'quit' to exit. If all words are hidden, pressing enter will also exit.");
            string input = Console.ReadLine();

            bool allHidden = false;
            int nonNumberWords = 0;
            int hiddenWords = 0;
            //This block will check to see if all words are hidden in order to know when to make the enter input exit the program
            foreach (Word word in allVerses.GetList())
            {
                if (!int.TryParse(word.GetWord(), out int number))
                {
                    nonNumberWords++;
                    if (word.GetIfHidden())
                    {
                        hiddenWords++;
                    }
                }
            }
            if (hiddenWords == nonNumberWords)
            {
                allHidden = true;
            }

            if (int.TryParse(input, out int numHidden))
            {
                allVerses.HideWords(numHidden);
                Console.Clear();
                reference.DisplayRef();
                allVerses.DisplayVerse();
            }
            else if (input == "")
            {
                if (allHidden)
                {
                    Console.WriteLine("Exiting");
                    isRunning = false;
                }
                else
                {
                    allVerses.HideWords();
                    Console.Clear();
                    reference.DisplayRef();
                    allVerses.DisplayVerse();
                }
            }
            else if (input == "quit")
            {
                Console.WriteLine("Exiting");
                isRunning = false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again");
            }
        }
    }   
}