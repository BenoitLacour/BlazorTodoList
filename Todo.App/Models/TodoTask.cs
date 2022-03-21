namespace Todo.Models;

public class TodoTask
{
    public TodoTask(string label, bool toggle)
    {
        this.Label = label;
        this.Toggle = toggle;
    }

    public string Label { get; set; }
    public bool Toggle { get; set; }

}