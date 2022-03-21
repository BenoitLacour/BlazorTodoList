using Microsoft.AspNetCore.Components;

namespace Todo.Components;

public partial class TaskList
{
    [Parameter, EditorRequired]
    public List<Models.Task> Tasks { get; set; } = null!;
    
    private void AddNewTask(Models.Task newTask)
    {
        Tasks.Add(newTask);
    }
}