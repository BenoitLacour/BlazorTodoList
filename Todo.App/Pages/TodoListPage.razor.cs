using Microsoft.AspNetCore.Components;
using Todo.Models;
using Todo.Services;

namespace Todo.Pages;

public partial class TodoListPage
{
    [Inject]
    public TodoListService TodoListService { get; set; }

    private string _newItem = String.Empty;

    protected override async Task OnInitializedAsync()
    {
        await LoadItems();
        await base.OnInitializedAsync();
    }

    private async Task LoadItems()
    {
        Items = await TodoListService.GetAll();
    }

    public IEnumerable<TodoItem> Items { get; set; } = Array.Empty<TodoItem>();

    private async Task AddItem()
    {
        await TodoListService.AddItem(_newItem);
        await LoadItems();
    }
}