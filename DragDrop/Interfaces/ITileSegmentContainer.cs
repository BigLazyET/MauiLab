using System.Collections.ObjectModel;
using DragDrop.Entities;

namespace DragDrop.Interfaces;

public interface ITileSegmentContainer<T>
{
    ObservableCollection<TileSegment<T>> TileSegments { get; set; }
}