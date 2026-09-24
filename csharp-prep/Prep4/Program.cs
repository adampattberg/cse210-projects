using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numberList = new List<int>();

        int numberUser = -1;
        while (numberUser != 0)
        {
            Console.Write("Enter number: ");
            numberUser = int.Parse(Console.ReadLine());
            numberList.Add(numberUser);
        }

        int numberSum = 0;
        foreach (int number in numberList)
        {
            numberSum += number;
        }

        Console.WriteLine($"The sum is: {numberSum}");

        float numberAvg = ((float)numberSum) / numberList.Count;
        Console.WriteLine($"The average is: {numberAvg}");

        int numberLarge = numberList[0];
        foreach (int number in numberList)
        {
            if (number > numberLarge)
            {
                numberLarge = number;
            }
        }
        Console.WriteLine($"The largest number is: {numberLarge}");
    }
}