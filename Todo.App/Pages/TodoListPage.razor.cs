using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Todo.Models;

namespace Todo.Pages; 
    
public partial class TodoListPage
{
    [Inject] private IJSRuntime JsRuntime { get; set; }
    private IJSObjectReference _jsModule;
    
    protected override async Task OnInitializedAsync()
    { 
        _jsModule = await JsRuntime.InvokeAsync<IJSObjectReference>("import", "./Pages/TodoListPage.razor.js");
        await _jsModule.InvokeVoidAsync("SetTodoListPageObjReference", DotNetObjectReference.Create(this));
        await base.OnInitializedAsync();
    }
 
    [Inject]
    public TodoList TodoList { get; set; }
    private string _newItem = String.Empty;
    
    private void AddItem()
    {
        TodoList.Add(_newItem);
    }

    [JSInvokable]
    public void Remove(string taskId)
    {
        TodoList.Remove(Guid.Parse(taskId)); 
        StateHasChanged();
    }
}