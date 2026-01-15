namespace AvaloniaWebView;

public static class AvaloniaWebViewBuilder
{
    public static AppBuilder UseWebViewAGPL(this AppBuilder builder, Action<WebViewCreationProperties>? configDelegate = default)
    {
        Initialize(configDelegate);
        
        return builder;
    }

    public static void Initialize(Action<WebViewCreationProperties>? configDelegate)
    {
        WebViewCreationProperties creationProperties = new();
        configDelegate?.Invoke(creationProperties);
        WebViewLocator.s_Registrator.RegisterInstance<WebViewCreationProperties>(creationProperties);
    }
}
