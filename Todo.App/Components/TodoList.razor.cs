using Microsoft.AspNetCore.Components;
using Todo.Model;

namespace Todo.Components;

public partial class TodoList
{
    private string _newItemTitle = String.Empty;
    [Parameter, EditorRequired] public Model.TodoList List { get; set; } = null!;
    
    private void AddItem()
    {
        List.Add(new Item(_newItemTitle, false));
        _newItemTitle = String.Empty;
    }
}