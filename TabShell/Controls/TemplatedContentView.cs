namespace TabShell.Controls;

public class TemplatedContentView : ContentView
{
    public static readonly BindableProperty ContentTemplateSelectorProperty =
        BindableProperty.Create(nameof(ContentTemplateSelector), typeof(DataTemplateSelector), typeof(TemplatedContentView), propertyChanged: OnTemplateChanged);

    public DataTemplateSelector? ContentTemplateSelector
    {
        get => (DataTemplateSelector)GetValue(ContentTemplateSelectorProperty);
        set => SetValue(ContentTemplateSelectorProperty, value);
    }

    public static readonly BindableProperty TemplateContextProperty =
        BindableProperty.Create(nameof(TemplateContext), typeof(object), typeof(TemplatedContentView), propertyChanged: OnTemplateChanged);

    public object? TemplateContext
    {
        get => GetValue(TemplateContextProperty);
        set => SetValue(TemplateContextProperty, value);
    }
    
    private static void OnTemplateChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is not TemplatedContentView templatedContentView) return;
        if (templatedContentView.ContentTemplateSelector == null || templatedContentView.TemplateContext == null) return;

        var dataTemplate = templatedContentView.ContentTemplateSelector.SelectTemplate(templatedContentView.TemplateContext,
            templatedContentView);
        var content = dataTemplate?.CreateContent();
        if (content is not View view) return;
        templatedContentView.Content = view;
    }
}