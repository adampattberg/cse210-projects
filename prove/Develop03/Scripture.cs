using System.Dynamic;

public class Scripture
{
    private Reference _reference;
    private List<string> _words = new List<string>();

    public Scripture ()
    {
        _words.Add("For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
    }

    public void SetReference(string scriptureReference)
    {
        Reference r1 = new Reference("John", 3, 16);
    }

    public void HideWords(int numberToHide)
    {
        
    }

    public string GetRenderedText()
    {
        return _words
    }

    public bool IsCompletelyHidden()
    {
        
    }
}