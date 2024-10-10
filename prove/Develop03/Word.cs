using System;
using System.IO;

public class Word
{
    private string _text;
    private bool _isHidden;

   
    public Word(string text)
    {
        _text = text;
        Show();
    }

    public string GetDisplayText()
    {
        if (_isHidden == false)
        {
            return _text; 
        }
        else
        {
   
            string blanks = "";

            foreach (char c in _text)
            {
                blanks = blanks + "_";
            }
            return blanks;
        }
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    private void Show()
    {
        _isHidden = false;
    }
}