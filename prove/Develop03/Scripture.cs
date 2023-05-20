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

/// <summary>
/// The function creates a list of Word objects from a given sentence by splitting it into individual
/// words and adding them to the list.
/// </summary>
/// <param name="sentance">The input sentence that needs to be split into words and stored in a
/// list.</param>
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
/// <summary>
/// The function creates a sentence by concatenating the rendered text of each word in a list.
/// </summary>
/// <returns>
/// The method `CreateSentance()` returns a string that represents a sentence created by concatenating
/// the rendered text of each word in the `_words` collection. The sentence is trimmed to remove any
/// leading whitespace.
/// </returns>
    private string CreateSentance()
    {
        string sentence = "";
        foreach (var word in _words)
        {
            sentence += $" {word.GetRenderedText()}";
        }
        return sentence.TrimStart();
    }

/// <summary>
/// The function returns a string that concatenates the display text of a reference object with the
/// rendered text of each word object in a list.
/// </summary>
/// <returns>
/// The method `GetRenderedText()` returns a string that represents the rendered text of a sentence. The
/// sentence is constructed by concatenating the display text of a reference object with the rendered
/// text of each word object in the sentence.
/// </returns>
    public string GetRenderedText()
    {
        string sentance = $"{_reference.Display()}";
        foreach (var word in _words)
        {
            sentance += $" {word.GetRenderedText()}";
        }
        return sentance;
    }
    
/// <summary>
/// The function hides three random words from a list of words, and sets a flag if all words have been
/// hidden.
/// </summary>
/// <returns>
/// If the `_wordIndex` list is empty, the `_isCompletelyHidden` variable is set to `true` and the
/// method returns. Otherwise, nothing is explicitly returned.
/// </returns>
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
    public string CreateFileString()
    {
        return $"{_reference.OutputForFile()}~|~{CreateSentance()}";
    }
    public string GetScriptureReference()
    {
    return _reference.Display();
    }





}