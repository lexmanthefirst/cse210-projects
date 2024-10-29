using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random _randGen = new Random();

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. " +
            "This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        DisplayStartingMessage(_name, _description);
        Console.WriteLine($"Running for {_duration} seconds");
        ShowReady(3);
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage(_name, _duration, 8);
    }

    private string GetRandomItem(List<string> items)
    {
        int index = _randGen.Next(items.Count);
        return items[index];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($"--- {GetRandomItem(_prompts)} ---\n");
        Console.Write("When you have something in mind, ");
        PressEnterToContinue();
    }

    private void DisplayQuestions()
    {
        Console.WriteLine("> Now ponder on each of the following questions as they relate to this experience:");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomItem(_questions)} ");
            ShowSpinner(15);
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}