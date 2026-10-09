using System;
using System.IO.Enumeration;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Journal
    {
        public Entry[] _entries = new Entry[0];
        public int _entryCount = 0;

// Create new entry
    public void WriteEntry()
    {
    // Pulls from Prompt.cs and runs ChoosePrompt
        Console.WriteLine("");
        Prompt promptGenerator1 = new Prompt();
        promptGenerator1.ChoosePrompt();
    // Adds to _entryCount, records user input through _input, records user mood through _mood
        Entry entry1 = new Entry();
        _entryCount = +1;
        entry1._input = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("What is your current mood?");
        entry1._mood = Console.ReadLine();


    }

// Recalls old entrys and displays them
    public void DisplayJournal()
    {
        Entry entryRecall1 = new Entry();
        entryRecall1.DisplayEntry();
    }

// Loads old file that was saved as txt file
// !!!!!!Need to change variables before submitting!!!!!!!
    public void LoadFromFile()
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }

// vvvvvvvv Saves new file as txt file vvvvvvvvv
// !!!!!!Need to change outputFile variables before submitting!!!!!!!
    public void SaveToFile()
    {
        string filename = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
    {
// You can add text to the file with the WriteLine method
        outputFile.WriteLine("This will be the first line in the file.");

// You can use the $ and include variables just like with Console.WriteLine
        string color = "Blue";
        outputFile.WriteLine($"My favorite color is {color}");
    }
    }

// Resizes array
    public void ResizeArray()
    {
        Console.WriteLine("Array Resized");
    }
    }