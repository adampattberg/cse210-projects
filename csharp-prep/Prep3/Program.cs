using System;
using System.Data;
using System.Runtime.Versioning;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int magicN = (number);

        int guessN = -1;

        while (guessN != magicN)
        {
            
            Console.Write("What is your guess? ");
            guessN = int.Parse(Console.ReadLine());

            if (guessN < magicN)
            {
                Console.WriteLine("Higher");
            }
            else if (guessN > magicN)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}