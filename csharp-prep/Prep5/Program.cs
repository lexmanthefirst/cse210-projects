using System;

class Program
{
    static void Main(string[] args)
    {
          static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        DisplayWelcome();

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;

        }
        string userName = PromptUserName();

        static int PromptUserNumber()
        {
            Console.Write("Please enter your number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        int userNumber = PromptUserNumber();

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        int square = SquareNumber(userNumber);

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is: {square}");

        }
        DisplayResult(userName, square);
    }
}