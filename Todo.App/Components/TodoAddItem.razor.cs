using Microsoft.AspNetCore.Components;
using Todo.Model;

namespace Todo.Components;

public partial class TodoAddItem
{
    [Parameter, EditorRequired] 
    public Model.TodoList List { get; set; } = null!;
    
    private string _newItemTitle = string.Empty;
    private void AddItem()
    {
        List.Add(new Item(_newItemTitle, false));
        _newItemTitle = string.Empty;
        StateHasChanged();
    }
}