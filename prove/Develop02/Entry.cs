public class Entry
{
    public string _prompt = "";
    public string _input = "";
    public string _dateTime = "10/5/2026";
    public string _mood = "";

    public void DisplayEntry()
    {
        Console.WriteLine("");
        Console.WriteLine($"{_dateTime}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"{_input}");
        Console.WriteLine($"{_mood}");
    }
}