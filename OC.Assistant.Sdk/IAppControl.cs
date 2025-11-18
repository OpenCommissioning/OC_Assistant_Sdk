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
    /// Triggers the application start state.
    /// </summary>
    public void Start();
    
    /// <summary>
    /// Triggers the application stop state.
    /// </summary>
    public void Stop();
    
    /// <summary>
    /// Adds content to the welcome page.
    /// </summary>
    /// <param name="content"></param>
    public void AddWelcomePageContent(object content);
    
    /// <summary>
    /// Is raised with the project file.
    /// </summary>
    public event Action<string>? Connected;
    
    /// <summary>
    /// Is raised when the project gets disconnected.
    /// </summary>
    public event Action? Disconnected;
    
    /// <summary>
    /// Is raised when a project is connected and TwinCAT started running.
    /// </summary>
    public event Action? StartedRunning;
    
    /// <summary>
    /// Is raised when a project is connected and TwinCAT stopped running.
    /// </summary>
    public event Action? StoppedRunning;
    
    /// <summary>
    /// Is raised with <c>True</c> when the project gets disconnected or when TwinCAT started running.<br/>
    /// Is raised with <c>False</c> when a project is connected and TwinCAT stopped running.
    /// </summary>
    public event Action<bool>? Locked;

    /// <summary>
    /// Is raised when a project configuration has been received.
    /// </summary>
    public event Action<XElement>? ConfigReceived;

    /// <summary>
    /// Is raised when a plugin has been updated.
    /// </summary>
    public event Action<string?, string?> PluginUpdated;
    
    /// <summary>
    /// The TimeScaling value.
    /// </summary>
    public double TimeScaling { get; }

    /// <summary>
    /// Gets a value indicating whether the connected project is currently running.
    /// </summary>
    public bool IsRunning { get; }
}