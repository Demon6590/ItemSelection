using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

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
}