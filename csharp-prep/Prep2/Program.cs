using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your score? ");
        string scoreString = Console.ReadLine();
        int score = int.Parse(scoreString);

        string letter = "";

        if(score >= 90)
        {
            letter = "A";
        }
        else if(score >= 80)
        {
            letter = "B";
        }
        else if(score >= 70)
        {
            letter = "C";
        }
        else if(score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if(score%10 >= 7)
        {
            letter+="+";
        } else if(score%10 <= 3){
            letter += "-";
        }

        if(score >= 90 && score%10 >= 7){
            letter = "A";
        }
        
        if(score < 60 && score%10 >3 && score%10 <= 7){
            letter = "F";
        } 
         Console.WriteLine($"You got a {letter}!");
         if(score > 70){
            Console.WriteLine($"You passed!");
         } else {
            Console.WriteLine("You failed!");
         }




    }
}