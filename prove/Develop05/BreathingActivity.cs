public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        string s1 = "This activity will help you relax by walking you through breathing ";
        string s2 = "in and out slowly. Clear you mind and focus on your breathing.";
        _description = s1 + s2;
    }

    public void Run()
    {
        DisplayStartingMessage(_name, _description);
        ShowReady(3);
        TakeBreath(_duration);
        DisplayEndingMessage(_name, _duration, 8);
    }

    private void TakeBreath(int runTime)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(runTime);

        int stringOption = 0;

        while (DateTime.Now < endTime)
        {
            if (stringOption == 0)
            {
                stringOption = 1;
                Console.Write("\n\nBreathe in...");
                ShowCountDown(4);
            }
            else
            {
                stringOption = 0;
                Console.Write("\nNow breathe out...");
                ShowCountDown(6);
            }
            Thread.Sleep(250);
        }
        Console.WriteLine("\n");
    }
}