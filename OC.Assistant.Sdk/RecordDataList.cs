namespace OC.Assistant.Sdk;

/// <summary>
/// Class to locate RecordData-subscribed devices. 
/// </summary>
internal static class RecordDataList
{
    public static readonly HashSet<uint> List = [];
    public static readonly object Lock = new();
    
    /// <summary>
    /// Determines whether the list contains the specified value.
    /// </summary>
    /// <param name="value">The value to locate.</param>
    /// <returns>True if the list contains the specified value, otherwise false.</returns>
    public static bool Contains(uint value)
    {
        lock (Lock)
        {
            return List.Contains(value);
        }
    }
}