using TabShell.Enums;
using TabShell.Views;

namespace TabShell.Controls;

public class MonkeyDataTemplateSelector : DataTemplateSelectorBase<MonkeyKind>
{
    public MonkeyDataTemplateSelector()
    {
        DataTemplateCreator = MonkeyDataTemplaCreator;
    }

    private static DataTemplate MonkeyDataTemplaCreator(MonkeyKind kind)
    {
        return kind switch
        {
            MonkeyKind.BorneoMonkey => new DataTemplate(() => new BorneoMonkeyView()),
            MonkeyKind.BrazilMonkey => new DataTemplate(() => new BrazilMonkeyView()),
            MonkeyKind.JapanMonkey => new DataTemplate(() => new JapanMonkeyView()),
            MonkeyKind.None or _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
        };
    }
}