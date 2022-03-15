namespace Todo.Model;

public class Item
{
    public Item(string Label, bool Toggle)
    {
        this.Label = Label;
        this.Toggle = Toggle;
    }

    public string Label { get; init; }
    public bool Toggle { get;  set; }

}