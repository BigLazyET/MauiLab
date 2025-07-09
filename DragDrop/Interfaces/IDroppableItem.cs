using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace DragDrop.Interfaces;

public interface IDroppableItem
{
    bool AllowDrop { get; set; }
    
    bool IsBeingDraggedOver { get; set; }

    IAsyncRelayCommand DragLeaveCommand { get; }
}

public interface IDroppableItem<T> : IDroppableItem
{
    IAsyncRelayCommand DragOverCommand { get; }
    
    IAsyncRelayCommand DropCommand { get; }
}