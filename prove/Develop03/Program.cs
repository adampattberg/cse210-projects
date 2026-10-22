using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world that he gave his one and only Son , that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string? input = Console.ReadLine();

            if (input?.ToLower() == "quit")
            {
                break;
            }

            scripture.HideWords(3);
        }
    }
}