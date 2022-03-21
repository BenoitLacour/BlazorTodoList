using Microsoft.AspNetCore.Components;
using Todo.Model;

namespace Todo.Components;

public partial class TodoItem
{
    [Parameter, EditorRequired]
    public Item Item { get; set; } = null!;
}