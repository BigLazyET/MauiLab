using CommunityToolkit.Mvvm.ComponentModel;

namespace DragDrop.Entities.Tiles;

public partial class Tile : ObservableObject
{
    [ObservableProperty] private bool _canDrag = true;
    [ObservableProperty] private bool _allowDrag = true;
}