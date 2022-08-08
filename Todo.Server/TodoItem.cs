namespace Todo.Server;

public class TodoItem
{
    public bool Done { get; set; }
    public string Label { get; set; }
    public Guid Id { get; set; }
}