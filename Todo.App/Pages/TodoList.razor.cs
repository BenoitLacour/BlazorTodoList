namespace Todo.Pages;

public partial class TodoList
{
    public List<string> Items { get; set; } = new List<string>()
    {
        "Ma première tache",
        "Acheter du pain",
        "Abonnez-vous"
    };

    private string _newItem = String.Empty;
    
    private void AddItem()
    {
        Items.Add(_newItem);
    }
}