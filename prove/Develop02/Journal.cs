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
        string chosenPrompt = promptGenerator1.ChoosePrompt();
    // Adds to _entryCount, records user input through _input, records user mood through _mood
        Entry entry1 = new Entry();
        entry1._prompt = chosenPrompt;
        entry1._input = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("What is your current mood?");
        entry1._mood = Console.ReadLine();

    // Resize array
        Array.Resize(ref _entries, _entries.Length + 1);
        _entries[_entries.Length - 1] = entry1;
        _entryCount++;
    }

// Recalls old entrys and displays them
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
            Console.WriteLine("");
        }
    }

// Loads old file that was saved as txt file
// !!!!!!Need to change variables before submitting!!!!!!!
    public void LoadFromFile()
    {
        Console.WriteLine("What is the name of the file? (Make sure to add .txt)");
        string filename = Console.ReadLine();
    // If file does not exist
        if (!File.Exists(filename))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _entries = new Entry[0];
        _entryCount = 0;

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry loadedEntry = new Entry();
            loadedEntry._prompt = parts[0];
            loadedEntry._dateText = parts[1];
            loadedEntry._input = parts[2];
            loadedEntry._mood = parts[3];

            Array.Resize(ref _entries, _entries.Length + 1);
            _entries[_entries.Length - 1] = loadedEntry;
            _entryCount++;
        }
        
        DisplayJournal();
    }

// vvvvvvvv Saves new file as txt file vvvvvvvvv
// !!!!!!Need to change outputFile variables before submitting!!!!!!!
    public void SaveToFile()
    {
        Console.WriteLine("What is the name of your file?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._dateText}|{entry._prompt}|{entry._input}|{entry._mood}");
            }
        }
    }
    }
