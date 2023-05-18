using System;
using System.Collections;
using System.Collections.Generic;
public class Scripture
{
    private List<Word> _words;
    private Reference _reference;
    private bool _isCompletelyHidden;
    private List<int> _wordIndex;

    public Scripture(Reference reference, string sentance)
    {
        _reference = reference;
        _isCompletelyHidden = false;
        CreateWordList(sentance);
    }


    private void CreateWordList(string sentance)
    {
        _words = new();
        _wordIndex = new();

        int index = 0;
        string[] words = sentance.Split(" ");
        foreach (var word in words)
        {
            _words.Add(new Word(word));
            _wordIndex.Add(index);
            index++;
        }

    }

    public string GetRenderedText()
    {
        string sentance = $"{_reference.Display()}";
        foreach (var word in _words)
        {
            sentance += $" {word.GetRenderedText()}";
        }
        return sentance;

    }

    public void HideWords()
    {
        for (int i = 0; i < 3; i++)
        {
            if (_wordIndex.Count == 0)
            {
                _isCompletelyHidden = true;
                return;
            }
            int index = GetRandomIndex();

            _words[_wordIndex[index]].Hide();
            _wordIndex.RemoveAt(index);
        }

        // // Just check if our loop of 3 was the last word to be hidden 
        // if (_wordIndex.Count == 0)
        // {
        //     _isCompletelyHiden = true;
        // }
    }

    public bool IsCompletlyHiden()
    {
        return _isCompletelyHidden;
    }

    private int GetRandomIndex()
    {
        Random rnd = new();
        var index = rnd.Next(_wordIndex.Count());
        return index;
    }





}