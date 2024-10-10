using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        string fullString;
        string response = "";

        Scripture script = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

        while (response != "quit")
        {
        
            fullString = script.GetDisplayText() + "\n";
            Console.WriteLine(fullString);

            if (script.IsCompletelyHidden())
            {
                Console.WriteLine("All words are now hidden - Memorization is complete\n");
                break;
            }

            script.HideRandomWords(3);

            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            response = Console.ReadLine();
        }
    }
}