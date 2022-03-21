using Microsoft.AspNetCore.Components;
using Todo.Models;

namespace Todo.Components;

public partial class TaskItem
{
    [Parameter, EditorRequired]
    public TodoTask Item { get; set; } = null!;
}