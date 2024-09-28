using System;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries;
    public PromptGenerator _promptGenerator;




    public Journal()
    {
        _entries = new List<Entry>();
        _promptGenerator = new PromptGenerator();


    }

    public void AddEntry(Entry newEntry)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        newEntry._date = DateTime.Now.ToShortDateString();
        newEntry._promptText = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Your prompt is: {newEntry._promptText}");
        Console.WriteLine("Enter your entry:");
        string entryText = Console.ReadLine();
        newEntry._entryText = entryText;
        _entries.Add(newEntry);

    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Prompt: --Date: {entry._date} {entry._promptText} --Entry: {entry._entryText}");

        }
    }


    public void LoadEntries(string filename)
    {
        if (filename.EndsWith(".csv"))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {

                string[] parts = line.Split("--");
                Entry e = new Entry();
                e._date = parts[0];
                e._promptText = parts[1];
                e._entryText = parts[2];
                _entries.Add(e);
                Console.WriteLine();
            }
        }
        else
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                String journalEntries = reader.ReadToEnd();
                Console.Write(journalEntries);
            }
        }
    }

    public void SaveEntries(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            if (filename.EndsWith(".csv"))
            {
                foreach (Entry e in _entries)
                {
                    outputFile.WriteLine($"{e._date}--{e._promptText}--{e._entryText}");
                }
            }
            else
            {
                foreach (Entry e in _entries)
                {
                    outputFile.WriteLine($"Date:{e._date},{e._promptText},{e._entryText}");
                    outputFile.WriteLine($"Prompt:{e._promptText}");
                    outputFile.WriteLine($"{e._entryText}");
                    outputFile.WriteLine();
                }
            }
        }
    }
}