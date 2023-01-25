using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Todo;
using Todo.Models;
using Todo.Pages;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});

builder.Services.AddSingleton(TodoList.CreateDemoList());

builder.Services.AddTransient<TodoListPageViewModel>();

await builder.Build().RunAsync();
