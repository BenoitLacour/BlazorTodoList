using Microsoft.AspNetCore.Components;
using Todo.Models;

namespace Todo.Components;

public partial class TaskAdd
{
    private string _newItemTitle = string.Empty;

    [Parameter, EditorRequired]
    public EventCallback<TodoTask> TaskAdded { get; set; }
    private async Task AddTask()
    {
        var newTask = new TodoTask(_newItemTitle, false);
        await TaskAdded.InvokeAsync(newTask);
    }

}