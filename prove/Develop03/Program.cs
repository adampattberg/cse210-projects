using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Scripture s1 = new Scripture();
        s1.SetReference("John 3:16");
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string info = Console.ReadLine();

            if (info.Equals("quit"))    
            {
                break;
            }
        }
    }
}