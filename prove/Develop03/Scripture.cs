using System.Dynamic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    public Scripture (Reference reference, string text)
    {
        _reference = reference;

        string[] pieces = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string piece in pieces)
        {
            _words.Add(new Word(piece));
        }
    }

    public void HideWords(int numberToHide)
    {
        List<Word> visibleWords = GetVisibleWords();

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetRenderedText()
    {
        List<string> renderedWords = new List<string>();
        foreach (Word word in _words)
        {
            renderedWords.Add(word.GetRenderedText());
        }

        return $"{_reference.GetDisplayText()} {string.Join(" ", renderedWords)}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

    private List<Word> GetVisibleWords()
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        return visibleWords;
    }
}