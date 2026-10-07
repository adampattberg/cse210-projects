using System.Collections.Generic;

public class Prompt
{
// Prompt List
    List<string> promptsList = new List<string>();
        public void promptsList.Add("Prompt1");
        public void promptsList.Add("Prompt2");
        public void promptsList.Add("Prompt3");
        public void promptsList.Add("Prompt4");
        public void promptsList.Add("Prompt5");

// Fetch Prompt
    string display1 = Prompt.promptsList[0];

    public void ChoosePrompt()
    {
        Console.WriteLine($"{display1}");
    }

}