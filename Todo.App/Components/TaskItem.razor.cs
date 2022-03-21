using Microsoft.AspNetCore.Components;

namespace Todo.Components;

public partial class TaskItem
{
    [Parameter, EditorRequired]
    public Models.Task Item { get; set; } = null!;
}