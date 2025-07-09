using TabShell.Enums;
using TabShell.Models;

namespace TabShell;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnTabSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (Tab.SelectedItem is not MonkeyKind kind) return;
        TemplatedView.TemplateContext = kind;
    }
}