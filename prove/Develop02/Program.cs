using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {

        Journal userJournal = new Journal();
        int userSelect = 0;

        while (userSelect !=5)
        {
            Console.WriteLine ("");
            Console.WriteLine ("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
            string userChoice = Console.ReadLine ();
            userSelect = int.Parse(userChoice);



            if (userSelect == 1)
            {   
                userJournal.WriteEntry();
            }

            if (userSelect == 2)
            {
                userJournal.DisplayJournal();
            }

            if (userSelect == 3)
            {
                userJournal.LoadFromFile();
            }

            if (userSelect == 4)
            {
                userJournal.SaveToFile();
            }

            if (userSelect == 5)
            {
                Console.WriteLine ("Goodbye");
            }
        }
    }
}