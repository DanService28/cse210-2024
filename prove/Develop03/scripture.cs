using System;
using System.Collections.Concurrent;
using System.ComponentModel;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random; 

    public Scripture(Reference reference, string referenceText)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random(); 

        foreach (string wordText in referenceText.Split(' '))
        {
            _words.Add(new Word(wordText));
        }
    }
    public void HideRandomWord()
    {
        List<Word> showedWords = _words.Where(word => !word.IsHidden()).ToList();

        if (showedWords.Count > 0)
        {
            int randomIndex = _random.Next(showedWords.Count);
            showedWords[randomIndex].Hide(); 
        }
    }

    public string GetDisplayText()
    {
        string displayReference = _reference.GetDisplayText() + ". ";

        List<string> displayWords = new List<string>();
        foreach (var word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        displayReference += string.Join(" ", displayWords);
        return displayReference;
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}