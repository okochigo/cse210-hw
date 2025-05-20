using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public bool HideRandomWords(int count)
    {
        int wordsHidden = 0;
        
        for (int i = 0; i < count && !IsCompletelyHidden(); i++)
        {
            int index;
            
            do
            {
                index = _random.Next(_words.Count);
            } while (_words[index].IsHidden());

            _words[index].Hide();
            wordsHidden++;
        }
        return wordsHidden > 0;
    }

    public string GetDisplayText()
    {
        string text = string.Join(" ", _words.ConvertAll(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()}\n{text}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}