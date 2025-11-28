namespace OC.Assistant.Sdk.Plugin;

/// <summary>
/// Defines the type of the variables structure.<br/>
/// </summary>
public enum IoType
{
    /// <summary>
    /// No variables.
    /// </summary>
    None,
    /// <summary>
    /// Address-based variables.<br/>
    /// e.g. I100, I101, Q100, Q101.
    /// </summary>
    Address,
    /// <summary>
    /// Specific structures.<br/>
    /// There will be an Inputs and an Outputs structure.<br/>
    /// The structures can be defined with the
    /// <see cref="PluginBase.InputStructure"/> and
    /// <see cref="PluginBase.OutputStructure"/> interfaces.
    /// </summary>
    Struct
}