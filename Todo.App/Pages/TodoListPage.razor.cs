using Microsoft.AspNetCore.Components;
using Todo.Models;
using Todo.Services;

namespace Todo.Pages;

public partial class TodoListPage
{

    [Inject]
    private TodoListService TodoListService { get; set; }

    private IEnumerable<TodoItem> Items { get; set; } = Array.Empty<TodoItem>();
    private string _newItem = String.Empty;

    protected override async Task OnInitializedAsync()
    {
        await LoadItems();
        await base.OnInitializedAsync();
    }

    private async Task AddItem()
    {
        await TodoListService.Add(_newItem);
        await LoadItems();
    }

    private async Task LoadItems()
    {
        Items = await TodoListService.GetItems();
    }
}