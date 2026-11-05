using System;
using System.Collections.Generic;
 
// Hands out items in random order and doesn't repeat any
// until every item has been used once (then it reshuffles).
public class PromptPool
{
    private List<string> _allItems;
    private List<string> _remaining = new List<string>();
    private Random _random = new Random();
 
    public PromptPool(List<string> items)
    {
        _allItems = items;
    }
 
    public string GetNext()
    {
        if (_remaining.Count == 0)
        {
            _remaining = new List<string>(_allItems);
        }
 
        int index = _random.Next(_remaining.Count);
        string item = _remaining[index];
        _remaining.RemoveAt(index);
        return item;
    }
}