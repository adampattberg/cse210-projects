using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine ("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
        string userChoice = Console.ReadLine ();
        
        if (userChoice = 1)
        {
            Journal entry1 = new Journal.WriteEntry;
        }

        if (userChoice = 2)
        {
            Journal display1 = new Journal.DisplayJournal;
        }

        if (userChoice = 3)
        {
            Journal load1 = new Journal.LoadFromFile;
        }

        if (userChoice = 4)
        {
            Journal save1 = new Journal.SaveToFile;
        }

        if (userChoice = 5)
        {
            Console.WriteLine ("Quitter")
        }
}