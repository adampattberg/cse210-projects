using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Scripture s1 = new Scripture();
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Scripture");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string info = Console.ReadLine();

            if (info.Equals("quit"))
            {
                break;
            }
        }
    }
}