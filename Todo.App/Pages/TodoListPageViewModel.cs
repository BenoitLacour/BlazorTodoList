using ReactiveUI;
using Todo.Models;

namespace Todo.Pages;

public class TodoListPageViewModel: ReactiveObject
{
    
    private string _search = string.Empty;
    private IEnumerable<TodoItem> _todoItems = Enumerable.Empty<TodoItem>();
    private readonly ObservableAsPropertyHelper<IEnumerable<TodoItem>> _filteredTodoItems;
    public IEnumerable<TodoItem> FilteredTodoItems => _filteredTodoItems.Value;

    public string Search
    {
        get => _search;
        set => this.RaiseAndSetIfChanged(ref _search, value);
    }

    public IEnumerable<TodoItem> TodoItems
    {
        get => _todoItems;
        set => this.RaiseAndSetIfChanged(ref _todoItems, value);
    }

    public ReactiveCommand<string,IEnumerable<TodoItem>> AddNewItemCommand { get; set; }
    
    public TodoListPageViewModel()
    {
        _filteredTodoItems = 
            this.WhenAnyValue(
                    x => x.Search, 
                    x=>x.TodoItems, 
                (search, items) 
                    => items.Where(x => x.Label.ToLower().Contains(search.ToLower())))
                .ToProperty(this, x => x.FilteredTodoItems, initialValue: TodoItems);

        AddNewItemCommand = ReactiveCommand.Create<string, IEnumerable<TodoItem>>(label => TodoItems.Append(new TodoItem(){Id = Guid.NewGuid() ,Label = label}));

        AddNewItemCommand.Subscribe(items => TodoItems = items);
    }

}