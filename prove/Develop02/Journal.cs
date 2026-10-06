using System.IO.Enumeration;

public class Journal
    {
        public void _entries = WriteEntry[];
        public int _entryCount = 0;
        public void _promptGenerator = Prompt;

    public void WriteEntry()
    {
        _entryCount = +1;
        _promptGenerator = ("");
    }

    public void DisplayJournal()
    {
        foreach (Journal entry in _entries)
        {
            entry.DisplayJournal();
        }
    }

    public void LoadFromFile(string)
    {
        fileName = Console.WriteLine("What is the file name?");
    }

    public void SaveToFile(string)
    {
        fileName = Console.WriteLine("What is the file name?");
    }

    public void ResizeArray()
    {
        Console.WriteLine("Array Resized");
    }
    }