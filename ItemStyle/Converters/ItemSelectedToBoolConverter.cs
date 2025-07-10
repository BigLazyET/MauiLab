using System.Globalization;
using ItemStyle.Models;

namespace ItemStyle.Converters;

public class ItemSelectedToBoolConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not MonkeyItem selectedItem) return false;
        if (parameter is not MonkeyItem item) return false;
        return selectedItem == item;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}