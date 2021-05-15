using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using ToDoAvalonia.NETCoreAvalonia.Services;
using ToDoAvalonia.NETCoreAvalonia.ViewModels;
using ToDoAvalonia.NETCoreAvalonia.Views;

namespace ToDoAvalonia.NETCoreAvalonia
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            base.OnFrameworkInitializationCompleted();

            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                var db = new Database();

                desktop.MainWindow = new MainWindow()
                {
                    DataContext = new MainWindowViewModel(db),
                };
            }
        }
    }
}