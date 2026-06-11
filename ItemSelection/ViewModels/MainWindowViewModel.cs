using System.Collections.ObjectModel;
using System.Linq;
using ReactiveUI.SourceGenerators;
namespace ItemSelection.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<ViewItem> Views => 
    [
        new ()
        {
            Name = "Студенты",
            ViewModel = new StudentsViewModel()
        },
        new ()
        {
            Name = "Предметы",
            ViewModel = new ItemsViewModel()
        },
    ];

    [Reactive] private ViewItem _currentViewModel;

    public MainWindowViewModel()
    {
        CurrentViewModel = Views[1];
    }
    [ReactiveCommand]
    private void SelectView(string viewName)
    {
        var targetView = Views.FirstOrDefault(v => v.Name == viewName);
        if (targetView != null)
        {
            CurrentViewModel = targetView;
        }
    }
}

public class ViewItem
{
    public required string Name { get; init;}
    public required ViewModelBase ViewModel { get; init; }
}