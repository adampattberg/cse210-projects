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
                Journal entry1 = new Journal();
                entry1.WriteEntry();
            }

            if (userSelect == 2)
            {
                Journal display1 = new Journal();
                display1.DisplayJournal();
            }

            if (userSelect == 3)
            {
                Journal load1 = new Journal();
                load1.LoadFromFile();
            }

            if (userSelect == 4)
            {
                Journal save1 = new Journal();
                save1.SaveToFile();
            }

            if (userSelect == 5)
            {
                Console.WriteLine ("Quitter");
            }
        }
    }
}