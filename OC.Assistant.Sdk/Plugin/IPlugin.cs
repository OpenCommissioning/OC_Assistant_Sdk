namespace OC.Assistant.Sdk.Plugin;

internal interface IPlugin
{
    string Name { get; }
    Type? Type { get; }
    Type? ClientType { get; }
    IPluginController? PluginController { get; }
    bool IsValid { get; }
}