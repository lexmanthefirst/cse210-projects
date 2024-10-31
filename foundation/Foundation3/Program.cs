using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
 
        List<Activity> activities = new List<Activity>
        {
            new RunningActivity(new DateTime(2024, 11, 3), 40, 3.0),
            new CyclingActivity(new DateTime(2023, 11, 3), 35, 12.0),
            new SwimmingActivity(new DateTime(2023, 11, 3), 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
    
}