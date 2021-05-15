using System.Collections.Generic;
using System.Collections.ObjectModel;
using ToDoAvalonia.NETCoreAvalonia.Models;

namespace ToDoAvalonia.NETCoreAvalonia.ViewModels
{
    public class TodoListViewModel : ViewModelBase
    {
        public TodoListViewModel(IEnumerable<TodoItem> items)
        {
            Item = new ObservableCollection<TodoItem>(items);
        }
        
        public ObservableCollection<TodoItem> Item { get; }
    }
}