using Microsoft.AspNetCore.Components;
using Todo.Models;

namespace Todo.Components;

public partial class TaskList
{
    [Parameter, EditorRequired]
    public List<TodoTask> Tasks { get; set; } = null!;
    
    private void AddNewTask(TodoTask newTodoTask)
    {
        Tasks.Add(newTodoTask);
    }
}