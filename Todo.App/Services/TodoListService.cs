using System.Net.Http.Json;
using Todo.Models;

namespace Todo.Services;

public class TodoListService
{
    private HttpClient _httpClient;

    public TodoListService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<TodoItem>> GetAll() =>
        await _httpClient.GetFromJsonAsync<IEnumerable<TodoItem>>("TodoList");


    public async Task AddItem(string name) =>
        await _httpClient.PostAsJsonAsync("TodoList", name);

}