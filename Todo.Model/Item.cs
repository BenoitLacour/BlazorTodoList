namespace Todo.Model;

public class Item
{
    public Item(string label, bool toggle)
    {
        this.Label = label;
        this.Toggle = toggle;
    }

    public string Label { get; init; }
    public bool Toggle { get; set; }

}

