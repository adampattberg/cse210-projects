public class Entry
{
    public string _prompt = "";
    public string _input = "";
    public string _dateText = DateTime.Now.ToShortDateString();
    public string _mood = "";

    public void DisplayEntry()
    {
        Console.WriteLine("");
        Console.WriteLine($"{_dateText}");
        Console.WriteLine("");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"{_input}");
        Console.WriteLine("");
        Console.WriteLine($"Your mood: {_mood}");
    }
}