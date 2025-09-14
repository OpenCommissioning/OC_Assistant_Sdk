namespace OC.Assistant.Sdk;

/// <summary>
/// Represents the local implementation of the Assistant API.
/// </summary>
public static class ApiLocal
{
    /// <summary>
    /// The project TimeScaling value.
    /// </summary>
    public static double TimeScaling { get; internal set; } = 1.0;
}