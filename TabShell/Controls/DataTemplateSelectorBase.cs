namespace TabShell.Controls;

public abstract class DataTemplateSelectorBase<T> : DataTemplateSelector
{
    public required Func<T, DataTemplate> DataTemplateCreator { get; init; }
    
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        if (DataTemplateCreator == null)
            throw new InvalidOperationException(nameof(DataTemplateCreator));
        return DataTemplateCreator.Invoke((T)item);
    }
}