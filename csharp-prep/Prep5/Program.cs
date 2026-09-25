using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = PromptUserName();
        int favNumber = PromptUserNumber();

        int squNumber = SquareNumber(favNumber);

        int birthYear;
        PromptUserBirthYear(out birthYear);

        DisplayResult(userName, squNumber, birthYear);


        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favNumber = int.Parse(Console.ReadLine());
            return favNumber;
        }

        static void PromptUserBirthYear(out int birthYear)
        {
            Console.Write("Please enter the year you were born: ");
            birthYear = int.Parse(Console.ReadLine());
        }

        static int SquareNumber(int favNumber)
        {
            int squNumber = favNumber * favNumber;
            return squNumber;
        }

        static void DisplayResult(string name, int squNumber, int birthYear)
        {
            Console.WriteLine($"{name}, the square of your number is {squNumber}");
            Console.WriteLine($"{name}, you will turn {2026 - birthYear} this year.");
        }
    }
}