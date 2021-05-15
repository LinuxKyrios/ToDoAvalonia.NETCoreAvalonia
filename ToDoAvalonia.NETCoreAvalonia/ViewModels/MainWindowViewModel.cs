using ToDoAvalonia.NETCoreAvalonia.Services;

namespace ToDoAvalonia.NETCoreAvalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(Database db)
        {
            List = new TodoListViewModel(db.GetItems());
        }
        
        public TodoListViewModel List { get; }
    }
}