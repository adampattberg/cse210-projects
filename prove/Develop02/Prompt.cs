using System.Collections.Generic;

public class Prompt
{
// Prompt List
    List<string> promptsList = new List<string>();
    string display1;

    public Prompt()
    {
        promptsList.Add("Prompt1");
        promptsList.Add("Prompt2");
        promptsList.Add("Prompt3");
        promptsList.Add("Prompt4");
        promptsList.Add("Prompt5");
    }

// Fetch Prompt
    public void ChoosePrompt()
    {
        Random random = new Random();
        int randomPrompt = random.Next(promptsList.Count);
        display1 = promptsList[randomPrompt];
        Console.WriteLine($"{display1}");
    }

}