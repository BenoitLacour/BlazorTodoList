namespace Todo.Model;

public class TodoList
{
    public void Add(Item todoItem)
    {
        Items.Add(todoItem);        
    }

    public int Count  => Items.Count;
    public IList<Item> Items { get; } = new List<Item>();

    public void Remove(Item todoItem)
    {
        Items.Remove(todoItem);
    }
}