using System;
 
class Program
{
    static void Main(string[] args)
    {
        // Create each activity once so promptpool doesn't repeat
        BreathingActivity breathing = new BreathingActivity();
        ReflectingActivity reflecting = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();
 
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
 
            string choice = Console.ReadLine();
 
            switch (choice)
            {
                case "1":
                    breathing.Run();
                    break;
                case "2":
                    reflecting.Run();
                    break;
                case "3":
                    listing.Run();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Please choose 1, 2, 3, or 4.");
                    System.Threading.Thread.Sleep(1500);
                    break;
            }
        }
    }
}