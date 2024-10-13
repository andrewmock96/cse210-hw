using System;
using System.Collections.Generic;


public class Scripture
{
    private ScriptureReference _reference;
    private List<Word> _words;


    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();


        string[] words = text.Split(' ');
        foreach (var word in words)
        {
            _words.Add(new Word(word));
        }
    }

    //display the scripture
    public void Display()
    {
        Console.WriteLine(_reference.GetFormattedReference());
        foreach (var word in _words)
        {
            Console.Write(word.Display() + " ");
        }
        Console.WriteLine();
    }

    //hide random words
    public void HideRandomWords()
    {
        Random rand = new Random();
        int wordsToHide = rand.Next(1,4);
        int hiddenCount = 0;


        while (hiddenCount < wordsToHide)
        {
            int index = rand.Next(0, _words.Count);
            if(!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    //Check if all words are hidden
    public bool AllWordsHidden()
    {
        foreach (var word in _words)
        {
            if(!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
