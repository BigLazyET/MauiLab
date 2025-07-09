using CommunityToolkit.Mvvm.Input;
using DragDrop.Entities.Tiles;

namespace DragDrop.Interfaces;

public interface IDragDropableViewModel
{
    IAsyncRelayCommand<MonkeyTile> DragStartingCommand { get; }
    
    IAsyncRelayCommand<MonkeyTile> DragOverCommand { get; }
    
    IAsyncRelayCommand<MonkeyTile> DropCommand { get; }
}