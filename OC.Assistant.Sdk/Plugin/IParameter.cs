namespace OC.Assistant.Sdk.Plugin;

/// <summary>
/// Represents the interface for a plugin parameter. 
/// </summary>
public interface IParameter
{
    /// <summary>
    /// The parameter name.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// The parameter value.
    /// </summary>
    object? Value { get; set; }
    /// <summary>
    /// The parameter tooltip, if any.
    /// </summary>
    object? ToolTip { get; }
    /// <summary>
    /// The file filter, if any.
    /// </summary>
    string? FileFilter { get; }
}