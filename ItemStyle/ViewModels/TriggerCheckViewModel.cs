using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ItemStyle.Models;

namespace ItemStyle.ViewModels;

public partial class TriggerCheckViewModel : ObservableObject
{
    [ObservableProperty] private ObservableCollection<MonkeyItem> _monkeys = [];

    public TriggerCheckViewModel()
    {
        InitMonkeys();
    }

    private void InitMonkeys()
    {
        Monkeys =
        [
            new MonkeyItem { Name = "Baboon", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg" },
            new MonkeyItem { Name = "Capuchin Monkey", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg" },
            new MonkeyItem { Name = "Blue Monkey", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg" },
            new MonkeyItem { Name = "Squirrel Monkey", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg" },
            new MonkeyItem { Name = "Golden Lion Tamarin", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg" },
            new MonkeyItem { Name = "Howler Monkey", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg" }
        ];
    }

    [RelayCommand]
    private void SelectionChanged(MonkeyItem item)
    {
        foreach (var monkeyItem in Monkeys)
            monkeyItem.IsSelected = false;
        item.IsSelected = true;
    }
}