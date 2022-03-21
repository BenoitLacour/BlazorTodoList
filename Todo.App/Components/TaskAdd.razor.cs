using Microsoft.AspNetCore.Components;

namespace Todo.Components;

public partial class TaskAdd
{
    private string _newItemTitle = string.Empty;

    [Parameter, EditorRequired]
    public EventCallback<Models.Task> TaskAdded { get; set; }
    private async Task AddTask()
    {
        var newTask = new Models.Task(_newItemTitle, false);
        await TaskAdded.InvokeAsync(newTask);
    }

}