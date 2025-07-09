using CommunityToolkit.Mvvm.Input;

namespace DragDrop.Controls;

public partial class DragDropView : ContentView
{
    public DragDropView()
    {
        InitializeComponent();
    }
    
    // public static readonly BindableProperty CanDragProperty = BindableProperty.Create(
    //     nameof(CanDrag), typeof(bool), typeof(DragDropView));
    //
    // public bool CanDrag
    // {
    //     get => (bool) GetValue(CanDragProperty);
    //     set => SetValue(CanDragProperty, value);
    // }
    //
    // public static readonly BindableProperty AllowDropProperty = BindableProperty.Create(
    //     nameof(AllowDrop), typeof(bool), typeof(DragDropView));
    //
    // public bool AllowDrop
    // {
    //     get => (bool) GetValue(AllowDropProperty);
    //     set => SetValue(AllowDropProperty, value);
    // }
    //
    // public static readonly BindableProperty DragStartingCommandProperty = BindableProperty.Create(
    //     nameof(DragStartingCommand), typeof(IAsyncRelayCommand), typeof(DragDropView));
    //
    // public IAsyncRelayCommand DragStartingCommand
    // {
    //     get => (IAsyncRelayCommand) GetValue(DragStartingCommandProperty);
    //     set => SetValue(DragStartingCommandProperty, value);
    // }
    //
    // public static readonly BindableProperty DropCommandProperty = BindableProperty.Create(
    //     nameof(DropCommand), typeof(IAsyncRelayCommand), typeof(DragDropView));
    //
    // public IAsyncRelayCommand DropCommand
    // {
    //     get => (IAsyncRelayCommand) GetValue(DropCommandProperty);
    //     set => SetValue(DropCommandProperty, value);
    // }
    //
    // public static readonly BindableProperty DragOverCommandProperty = BindableProperty.Create(
    //     nameof(DragOverCommand), typeof(IAsyncRelayCommand), typeof(DragDropView));
    //
    // public IAsyncRelayCommand DragOverCommand
    // {
    //     get => (IAsyncRelayCommand) GetValue(DragOverCommandProperty);
    //     set => SetValue(DragOverCommandProperty, value);
    // }
    //
    // public static readonly BindableProperty DragLeaveCommandProperty = BindableProperty.Create(
    //     nameof(DragLeaveCommand), typeof(IAsyncRelayCommand), typeof(DragDropView));
    //
    // public IAsyncRelayCommand DragLeaveCommand
    // {
    //     get => (IAsyncRelayCommand) GetValue(DragLeaveCommandProperty);
    //     set => SetValue(DragLeaveCommandProperty, value);
    // }
}