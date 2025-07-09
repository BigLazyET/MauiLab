namespace DragDrop.Interfaces;

public interface ITileSegment<T> : IDraggableItem<T>, IDroppableItem<T>
{
    T Tile { get; set; }
}