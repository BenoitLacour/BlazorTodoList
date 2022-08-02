using Microsoft.AspNetCore.Components;
using Todo.Models;

namespace Todo.Pages;

public partial class TodoListPage
{

    [Inject]
    public TodoList TodoList { get; set; }

    private string _newItem = String.Empty;
    
    private void AddItem()
    {
        TodoList.Add(_newItem);
    }
}