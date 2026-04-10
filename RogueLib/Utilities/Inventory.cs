using System.Collections.Generic;
using RogueLib.Dungeon;

namespace RogueLib.Utilities;

public class Inventory
{
    // We use the base class 'Item' so the list can hold Gold, Potions, Swords, etc.
    private List<Item> _contents = new List<Item>();
    public int Capacity { get; init; } = 10; // Max items allowed

    public bool Add(Item item)
    {
        if (_contents.Count < Capacity)
        {
            _contents.Add(item);
            return true;
        }
        return false; // Inventory is full!
    }

    public void Remove(Item item)
    {
        if (_contents.Contains(item))
            _contents.Remove(item);
    }

    public List<Item> GetItems() => _contents;
}
