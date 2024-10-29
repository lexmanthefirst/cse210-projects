public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected int _runTime = 3;

    public void DisplayStartingMessage(string name, string description)
    {
    
        Console.WriteLine($"Welcome to the {name} Activity.\n");
        Console.WriteLine($"{description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayEndingMessage(string activity, int duration, int ready)
    {
        Console.WriteLine("Well done!!\n");
        ShowSpinner(2);
        Console.WriteLine($"You have completed another {duration} seconds of the {activity} Activity.");
        ShowSpinner(ready);
    }
    public void ShowSpinner(int runTime)
    {
        // Spinner charaters:  | / - \ | / - \ |
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        _runTime = runTime;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_runTime);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");   // backspace blank backspace

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int second)
    {
        for (int i = second; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");   // backspace blank backspace
        }
    }

    public void ShowReady(int ready)
    {
    
        Console.WriteLine("Get ready...");
        ShowSpinner(ready);
    }

    public void PressEnterToContinue()
    {
        Console.WriteLine("press enter to continue.");
        string puase = Console.ReadLine();
    }
    public void DebugPause()
    {
        string pause = Console.ReadLine();
    }
}