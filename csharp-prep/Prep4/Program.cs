using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int num = -1;


        while (num != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished ");
            num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                numbers.Add(num);
            }

        }
        //SUM
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers is {sum}");

        //Average
        float avg = (float)sum / numbers.Count;
        Console.WriteLine($"The average of the numbers is {avg}");

        //Max
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max of the numbers is {max}");

        //Min
        int min = numbers[0];
        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }
        Console.WriteLine($"The min of the numbers is {min}");

        //Sort
        numbers.Sort();
        Console.WriteLine("The sorted list in ascending order is:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}