using System.Reactive.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Todo.Models;

namespace Todo.Pages; 
    
public partial class TodoListPage
{
    [Inject]
    public TodoList TodoList { get; set; }
    private string _newItem = String.Empty;

    protected override void OnParametersSet()
    {
        ViewModel!.TodoItems = TodoList.Items.ToList();
        base.OnParametersSet();
    }

    private void AddItem()
    {
        ViewModel!.AddNewItemCommand.Execute(_newItem).ToTask();
    }
}