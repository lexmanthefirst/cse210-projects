using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        
    Random randomGenerator = new Random();

    int magicNumber = randomGenerator.Next(1, 101);

    // Console.WriteLine(magicNumber);

    int guess = -1;
    int guessCount = 0;

    while(guess != magicNumber){
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());
        guessCount++;

        if(magicNumber > guess){
            Console.WriteLine($"Your guess pf {guess} is lower!");
        } else if(magicNumber < guess){
            Console.WriteLine($"Your guess pf {guess} is Higher");
        } else {
            Console.WriteLine($"Your guessed it!");
            Console.WriteLine($"You guess it {guessCount} times.");
        }
    }

    Console.Write("Do you want to play again? (Y / N)");

    string playAgain = Console.ReadLine().ToLower();

    if(playAgain == "y" || playAgain == "yes") {
        
        Random randomGeneratorTwo = new Random();

        int magicNumberTwo = randomGeneratorTwo.Next(1, 101);

        // Console.WriteLine(magicNumberTwo);

        int guessTwo = -1;
        int guessCountTwo = 0;

        while(guessTwo != magicNumberTwo) {
            Console.Write("What is your guess? ");
            guessTwo = int.Parse(Console.ReadLine());
            guessCountTwo++;

            if(magicNumberTwo > guessTwo) {
                Console.WriteLine($"Your guess of {guessTwo} is lower!");
            } else if(magicNumberTwo < guessTwo) {
                Console.WriteLine($"Your guess of {guessTwo} is higher!");
            } else {
                Console.WriteLine($"Your guessed it!");
                Console.WriteLine($"You guessed it {guessCountTwo} times.");
            }
        }
    }



    }
}