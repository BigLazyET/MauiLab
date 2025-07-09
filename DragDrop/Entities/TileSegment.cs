using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DragDrop.Interfaces;

namespace DragDrop.Entities;

public partial class TileSegment<T> : ObservableObject, ITileSegment<T>
{
    [ObservableProperty] private bool _canDrag = true;
    [ObservableProperty] private bool _allowDrop = true;

    public bool IsBeingDragged { get; set; }
    public bool IsBeingDraggedOver { get; set; }
    
    public T Tile { get; set; }

    public ITileSegmentContainer<T> Container { get; set; }

    [RelayCommand] private Task DragStarting() => DragStartingAction();

    [RelayCommand] private Task DragLeave() => DragLeaveAction();

    [RelayCommand] private Task DragOver() => DragOverAction();

    [RelayCommand] private Task Drop() => DropAction();

    protected virtual Task DragStartingAction()
    {
        if (CanDrag == false) return Task.CompletedTask;
        
        IsBeingDragged = true;
        return Task.CompletedTask;
    }

    protected virtual Task DragLeaveAction()
    {
        if (AllowDrop == false) return Task.CompletedTask;
        
        IsBeingDraggedOver = false;
        return Task.CompletedTask;
    }

    protected virtual Task DragOverAction()
    {
        if (AllowDrop == false || IsBeingDragged == true) return Task.CompletedTask;

        IsBeingDraggedOver = true;
        return Task.CompletedTask;
    }

    protected virtual Task DropAction()
    {
        if (AllowDrop == false) return Task.CompletedTask;
        
        var itemToMove = Container.TileSegments.FirstOrDefault(t => t.IsBeingDragged == true);
        if (itemToMove == null || itemToMove == this) return Task.CompletedTask;
        
        var oldIndex = Container.TileSegments.IndexOf(itemToMove);
        var newIndex = Container.TileSegments.IndexOf(this);
        Container.TileSegments.Move(oldIndex, newIndex);
        itemToMove.IsBeingDragged = false;
        IsBeingDraggedOver = false;
        
        return Task.CompletedTask;
    }
}