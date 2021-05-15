using System.Collections.Generic;
using System.Collections.ObjectModel;
using ToDoAvalonia.NETCoreAvalonia.Models;

namespace ToDoAvalonia.NETCoreAvalonia.ViewModels
{
    public class TodoListViewModel : ViewModelBase
    {
        public TodoListViewModel(IEnumerable<TodoItem> item)
        {
            Item = new ObservableCollection<TodoItem>(item);
        }
        
        public ObservableCollection<TodoItem> Item { get; }
    }
}