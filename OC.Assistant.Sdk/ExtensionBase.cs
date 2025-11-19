namespace OC.Assistant.Sdk;

/// <summary>
/// The base class for an extension.
/// </summary>
/// <param name="appControl">The <see cref="IAppControl"/> interface to control the application.</param>
public class ExtensionBase(IAppControl appControl)
{
    /// <inheritdoc cref="IAppControl"/>
    public IAppControl AppControl { get; } = appControl;
}