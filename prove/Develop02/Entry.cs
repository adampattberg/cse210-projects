public class Entry
{
    public string _prompt = "";
    public string _input = "";
    string _dateText = DateTime.Now.ToShortDateString();
    public string _mood = "";

    public void DisplayEntry()
    {
        Console.WriteLine($"{_prompt}");
        Console.WriteLine("");
        Console.WriteLine($"{_dateText}");
        Console.WriteLine("");
        Console.WriteLine($"{_input}");
        Console.WriteLine("");
        Console.WriteLine($"{_mood}");
    }
}