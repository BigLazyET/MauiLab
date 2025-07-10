using CommunityToolkit.Mvvm.ComponentModel;

namespace ItemStyle.Models;

public partial class ItemBase : ObservableObject
{
    [ObservableProperty] private string _textColor;
    
    [ObservableProperty] private string _bgColor;

    [ObservableProperty] private bool _isSelected;
}