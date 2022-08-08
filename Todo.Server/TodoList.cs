using System.Collections.ObjectModel;

namespace Todo.Server;

public class TodoList
{
    private readonly List<TodoItem> _items = new();
    
    public ReadOnlyCollection<TodoItem> Items => _items.AsReadOnly();
    
    public void Add(string newItem) => _items.Add(new TodoItem { Label = newItem, Id = Guid.NewGuid() });
    
    public int Count => _items.Count;
    
    public static TodoList CreateDemoList()
    {
        var todoList = new TodoList();
        todoList.Add("Ma première tâche");
        todoList.Add("Acheter du pain");
        todoList.Add("Abonnez-vous");
        return todoList;
    }
}