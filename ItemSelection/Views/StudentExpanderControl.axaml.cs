using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using Avalonia.VisualTree;
using ItemSelection.Models;
using ItemSelection.ViewModels;

namespace ItemSelection.Views;

public partial class StudentExpanderControl : UserControl
{
    public static readonly StyledProperty<string> HeaderProperty =
        AvaloniaProperty.Register<StudentExpanderControl, string>(nameof(Header));
    public string Header
    {
        get => GetValue(HeaderProperty);
        set => SetValue(HeaderProperty, value);
    }
    public StudentExpanderControl()
    {
        InitializeComponent();
    }
    private void Student_Tapped(object? sender, TappedEventArgs e)
    {

        if (sender is StackPanel panel && panel.DataContext is Student clickedStudent)
        {
            var mainView = this.FindAncestorOfType<ItemsView>();
            
            if (mainView?.DataContext is ItemsViewModel mainVm)
            {
                mainVm.AddItemToStudent(clickedStudent, Header);

                StudentsList.SelectedItem = null;
            }
        }
    }
    
}