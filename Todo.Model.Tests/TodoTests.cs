using FluentAssertions;
using Xunit;

namespace Todo.Model.Tests;

public class TodoTests
{
    [Fact]
    public void Should_create_a_valid_todo_item()
    {
        var todoItem = new Item("monItem", false);

        todoItem.Label.Should().Be("monItem");
        todoItem.Toggle.Should().BeFalse();
    }

    [Fact]
    public void Should_toggle_item()
    {
        var todoItem = new Item("monItem", false);

        todoItem.Toggle = !todoItem.Toggle;

        todoItem.Toggle.Should().BeTrue();
    }

    [Fact]
    public void Should_add_item()
    {
        var todoList = new TodoList();
        var todoItem = new Item("monItem", false);

        todoList.Add(todoItem);

        todoList.Count.Should().Be(1);
        todoList.Items.Should().ContainEquivalentOf(todoItem);
    }
    
    [Fact]
    public void Should_remove_item()
    {
        var todoList = new TodoList();
        var todoItem = new Item("monItem", false);
        todoList.Add(todoItem);

        todoList.Remove(todoItem);
        
        todoList.Count.Should().Be(0);
        todoList.Items.Should().NotContainEquivalentOf(todoItem);
    }
}