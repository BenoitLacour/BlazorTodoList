using System.Net.Http.Json; 
using Todo.Models;

namespace Todo.Services;

public class TodoListService
{
    private readonly HttpClient _httpClient;

    public TodoListService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<IEnumerable<TodoItem>> GetItems()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<TodoItem>>("TodoList");
    }

    public async Task Add(string newItem)
    {
        await _httpClient.PostAsJsonAsync("TodoList",newItem);
    }

    public async Task ToggleItem(Guid guid)
    {
        await _httpClient.PostAsJsonAsync($"TodoList/{guid}/toggle","");
    }
}