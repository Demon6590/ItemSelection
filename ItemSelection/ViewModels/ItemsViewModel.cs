using ReactiveUI.SourceGenerators;
using ItemSelection.Models;

namespace ItemSelection.ViewModels;

public partial class ItemsViewModel : ViewModelBase
{

    [ReactiveCommand]
    private void AddItemToStudent(Student student, string itemName)
    {
        if (!student.Items.Contains(itemName))
        {
            student.Items.Add(itemName);
        }
    }
}