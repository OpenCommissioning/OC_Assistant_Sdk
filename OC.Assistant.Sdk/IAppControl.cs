using System.Xml.Linq;

namespace OC.Assistant.Sdk;

/// <summary>
/// Interface to control the application.
/// </summary>
public interface IAppControl
{
    /// <summary>
    /// Connects to a project file.
    /// </summary>
    /// <param name="projectFile">The path of the project file.</param>
    public void Connect(string projectFile);
    
    /// <summary>
    /// Disconnects from the currently connected Visual Studio Solution.
    /// </summary>
    public void Disconnect();
    
    /// <summary>
    /// Triggers the application to start all plugins of the given type.
    /// </summary>
    public void StartPlugins(Type? clientType);
    
    /// <summary>
    /// Triggers the application to stop all plugins of the given type.
    /// </summary>
    public void StopPlugins(Type? clientType);
    
    /// <summary>
    /// Adds content to the menu.
    /// </summary>
    /// <param name="content"></param>
    public void AddMenuContent(object content);
    
    /// <summary>
    /// Adds content to the welcome page.
    /// </summary>
    /// <param name="content"></param>
    public void AddWelcomePageContent(object content);
    
    /// <summary>
    /// Is raised with the project file when the project gets connected.
    /// </summary>
    public event Action<string>? Connected;
    
    /// <summary>
    /// Is raised when the project gets disconnected.
    /// </summary>
    public event Action? Disconnected;

    /// <summary>
    /// Is raised when a project configuration has been received.
    /// </summary>
    public event Action<XElement>? ConfigReceived;

    /// <summary>
    /// Is raised when a plugin has been updated.
    /// </summary>
    public event Action<string?, string?>? PluginUpdated;
    
    /// <summary>
    /// Is raised when the TimeScaling value has been updated.
    /// </summary>
    public event Action<double>? TimeScalingUpdated;
}