using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        Entry promptDisplay = new Entry();



        Console.WriteLine("Welcome to Your Daily Journal!");

        while (true)
        {


            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.WriteLine("What would you like to do? Enter a choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Entry newEntry = new Entry();
                    myJournal.AddEntry(newEntry);
                    break;
                case "2":
                    myJournal.DisplayAll();
                    break;
                case "3":

                    Console.Write("Enter the file name you want to save: ");
                    string saveFileName = Console.ReadLine();
                    myJournal.SaveEntries(saveFileName);
                    Console.WriteLine("Your file has been saved!");
                    Console.WriteLine();

                    break;
                case "4":

                    Console.Write("Enter the file name you want to load: ");
                    string loadFileName = Console.ReadLine();
                    myJournal.LoadEntries(loadFileName);
                    Console.WriteLine();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }



    }
}