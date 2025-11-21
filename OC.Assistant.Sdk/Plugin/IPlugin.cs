namespace OC.Assistant.Sdk.Plugin;

/// <summary>
/// Represents the interface for a plugin.
/// </summary>
public interface IPlugin
{
    /// <summary>
    /// The plugin name.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// The plugin type.
    /// </summary>
    Type? Type { get; }
    /// <summary>
    /// The client type.
    /// </summary>
    Type? ClientType { get; }
    /// <summary>
    /// The interface to control the plugin.
    /// </summary>
    IPluginController? PluginController { get; }
}