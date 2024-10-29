public class ListingActivity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Running...");
        DisplayPrompt();
        DisplayEndingMessage();
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("You may begin in 5 seconds.");
        ShowCountDown(5);
        ShowPrompt();
    }

    private string GetRandomPrompt()
    {
        Random randGen = new Random();
        int index = randGen.Next(0, _prompts.Count);
        return _prompts[index];
    }

    private void ShowPrompt()
    {
        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(8);

        while (DateTime.Now < endTime)
        {
            count++;
            Console.Write("> ");
            Console.ReadLine();
        }

        Console.WriteLine($"You listed {count} items!\n");
    }

    private void DisplayStartingMessage()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life");
        Console.WriteLine("by having you list as many things as you can in a certain area.");
    }

    private void DisplayEndingMessage()
    {
        Console.WriteLine("Activity completed!");
    }

    private void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}... ");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}