using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade percentage?");
        string gradeS = Console.ReadLine();
        int grade = int.Parse(gradeS);
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70 )
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (grade >= 70)
        {
            Console.WriteLine("Congrats on passing this course!");
        }
        else
        {
            Console.WriteLine("I'm sure you can pass next time!");
        }
    }
}