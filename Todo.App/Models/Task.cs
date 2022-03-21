namespace Todo.Models;

public class Task
{
    public Task(string label, bool toggle)
    {
        this.Label = label;
        this.Toggle = toggle;
    }

    public string Label { get; set; }
    public bool Toggle { get; set; }

}