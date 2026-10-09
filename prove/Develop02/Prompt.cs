using System.Collections.Generic;

public class Prompt
{
// Prompt List
    List<string> promptsList = new List<string>();
    string display1;

    public Prompt()
    {
        promptsList.Add("What was the most interesting conversation you had recently?");
        promptsList.Add("What gave you the most joy over the last week?");
        promptsList.Add("What is a small act of kindness that you or someone you known performed recently?");
        promptsList.Add("What is a positive habit you have been growing?");
        promptsList.Add("What was the reason for you to laugh recently?");
    }

// Fetch Prompt
    public string ChoosePrompt()
    {
        Random random = new Random();
        int randomPrompt = random.Next(promptsList.Count);
        display1 = promptsList[randomPrompt];
        Console.WriteLine($"{display1}");
        return display1;
    }

}