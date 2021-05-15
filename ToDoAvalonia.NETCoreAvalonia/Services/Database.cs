using System.Collections.Generic;
using ToDoAvalonia.NETCoreAvalonia.Models;

namespace ToDoAvalonia.NETCoreAvalonia.Services
{
    public class Database
    {
        public IEnumerable<TodoItem> GetItems() => new[]
        {
            new TodoItem { Description = "ASP.NET" },
            new TodoItem { Description = "ASP.NET Core" },
            new TodoItem { Description = "Vue" },
            new TodoItem { Description = "Angular" },
            new TodoItem { Description = "Mastering Avalonia", IsChecked = true },
        };
    }
}