using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace DragDrop.Interfaces;

public interface IDraggableItem
{
    bool CanDrag { get; set; }
    
    bool IsBeingDragged { get; set; }
}

public interface IDraggableItem<T> : IDraggableItem
{
    IAsyncRelayCommand DragStartingCommand { get; }
}