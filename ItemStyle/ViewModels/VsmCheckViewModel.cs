using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ItemStyle.Models;

namespace ItemStyle.ViewModels;

public partial class VsmCheckViewModel : ObservableObject
{
    [ObservableProperty] private ObservableCollection<MonkeyItem> _monkeys = [];

    public VsmCheckViewModel()
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
            new MonkeyItem { Name = "Howler Monkey", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg" },
            new MonkeyItem { Name = "Japanese Macaque", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Macaca_fuscata_fuscata1.jpg/220px-Macaca_fuscata_fuscata1.jpg"},
            new MonkeyItem { Name = "Mandrill", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Mandrill_at_san_francisco_zoo.jpg/220px-Mandrill_at_san_francisco_zoo.jpg"},
            new MonkeyItem { Name = "Proboscis Monkey", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Proboscis_Monkey_in_Borneo.jpg/250px-Proboscis_Monkey_in_Borneo.jpg"},
            new MonkeyItem { Name = "Red-shanked Douc", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Portrait_of_a_Douc.jpg/159px-Portrait_of_a_Douc.jpg"},
            new MonkeyItem { Name = "Gray-shanked Douc", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Cuc.Phuong.Primate.Rehab.center.jpg/320px-Cuc.Phuong.Primate.Rehab.center.jpg"},
            new MonkeyItem { Name = "Golden Snub-nosed Monkey", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg/165px-Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg"},
            new MonkeyItem { Name = "Black Snub-nosed Monkey", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/RhinopitecusBieti.jpg/320px-RhinopitecusBieti.jpg"},
            new MonkeyItem { Name = "Tonkin Snub-nosed Monkey", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg/320px-Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg"},
            new MonkeyItem { Name = "Thomas's Langur", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Thomas%27s_langur_Presbytis_thomasi.jpg/142px-Thomas%27s_langur_Presbytis_thomasi.jpg"},
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