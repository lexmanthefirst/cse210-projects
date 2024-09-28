using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Famtech Computer Institute";
        job1._startYear = 2005;
        job1._endYear = 2024;

        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Senior Software Engineer";
        job2._company = "ABC Industries";
        job2._startYear = 2015;
        job2._endYear = 2022;
        
        job2.DisplayJobDetails();

        Resume lexResume = new Resume();
        lexResume._name = "Alex Okhitoya";

        lexResume._jobs.Add(job1);
        lexResume._jobs.Add(job2);

        lexResume.Display();
    }
}