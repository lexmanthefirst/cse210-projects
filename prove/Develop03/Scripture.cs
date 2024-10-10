using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


public class Scripture
{

    private Reference _reference;
    private List<Word> _words = new List<Word>();


    public Scripture(string reference, string text)
    {
        string[] referenceText = reference.Split(' ', ':', '-');
        string _book = referenceText[0];
        int _chapter = int.Parse(referenceText[1]);
        int _verse = int.Parse(referenceText[2]);
        int _endVerse = int.Parse(referenceText[3]);


        if (referenceText[3] != null)
        {
            _reference = new Reference(_book, _chapter, _verse, _endVerse);
        }
        else
        {
            _reference = new Reference(_book, _chapter, _verse);
        }

        string[] fullText = text.Split();

        foreach (string item in fullText)
        {
            Word oneWord = new Word(item);
            _words.Add(oneWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int number;
        int max = _words.Count();

        for (int i = 0; i < numberToHide; i++)
        {
            Random randGen = new Random();

            number = randGen.Next(0, max);

            while (_words[number].IsHidden() == true)
            {
                number = randGen.Next(0, max);
            }
            _words[number].Hide();
        }
    }

    public string GetDisplayText()
    {
        string text = "";
        text = _reference.GetDisplayText();

        foreach (Word item in _words)
        {
            text = text + " " + item.GetDisplayText();
        }
        return text;
    }

    public bool IsCompletelyHidden()
    {
        bool _complete = true;

        foreach (Word item in _words)
        {
            if (item.IsHidden() == false)
            {

                return false;
            }
        }
        return _complete;
    }
}