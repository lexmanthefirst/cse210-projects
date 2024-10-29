//-------------------------------------------------------------------
// STRETCH CHALLENGE - Added to the Program class:
// Counted and reported the number of each activity that was run
// before quiting.
//-------------------------------------------------------------------
using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {


        int menuOption = 0;
        BreathingActivity breath = new();
        ListingActivity listen = new();
        ReflectingActivity reflect = new();

        int breatheCnt = 0; // Exceeding Requirements
        int reflectCnt = 0; // Exceeding Requirements
        int listingCnt = 0; // Exceeding Requirements

        while (menuOption < 4)
        {

            menuOption = DisplayMenu();
            switch (menuOption)
            {
                case 1:
                    breath.Run();
                    breatheCnt++; // Exceeding Requirements
                    break;
                case 2:
                    reflect.Run();
                    reflectCnt++; // Exceeding Requirements
                    break;
                case 3:
                    listen.Run();
                    listingCnt++; // Exceeding Requirements
                    break;
                default:
                    Console.WriteLine();
                    break;
            }

            // Exceeds Requirements - Final Printout
            Console.WriteLine("You ran the following number of activities:");
            Console.WriteLine($"Breathing activities : {breatheCnt}");
            Console.WriteLine($"Reflecting activities: {reflectCnt}");
            Console.WriteLine($"Listing activities   : {listingCnt}\n");
        }
    }

    static int DisplayMenu()
    {
        string value;
        int choice = 0;

        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
        value = Console.ReadLine();
        choice = int.Parse(value);
        return choice;
    }
}