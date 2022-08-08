using Microsoft.AspNetCore.Mvc;

namespace Todo.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoListController : ControllerBase
{
    private readonly TodoList _todoList;

    public TodoListController(TodoList todoList)
    {
        _todoList = todoList;
    }
 
    [HttpGet("")]
    public List<TodoItem> All() => _todoList.Items.ToList();
     
    [HttpGet("{id}")]
    public TodoItem? Get(Guid id) => _todoList.Items.FirstOrDefault(item=> item.Id == id);
    
    [HttpGet("count")]
    public int Count() => _todoList.Count;

    [HttpPost]
    public void Add([FromBody]string todoItem) => _todoList.Add(todoItem);
    
    [HttpPost("{id}/toggle")]
    public void Toggle([FromRoute] Guid id)
    {
        var item = _todoList.Items.First(item => item.Id == id);
        item.Done = !item.Done;
    }
}