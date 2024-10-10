using System;
using System.IO;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }


    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        string bookString;
        string verseString;
        string refString;

        bookString = $"{_book} {_chapter.ToString()}:";

        if (_endVerse == 0)
        {
            verseString = _verse.ToString();
        }
        else
        {
            verseString = _verse.ToString() + "-" + _endVerse.ToString();
        }

        refString = bookString + verseString;

        return (refString);
    }
}