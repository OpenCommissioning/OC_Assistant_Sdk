using System.Collections.Concurrent;

namespace OC.Assistant.Sdk;

/// <summary>
/// Class to locate RecordData-subscribed devices. 
/// </summary>
public static class RecordDataList
{
    private static readonly ConcurrentDictionary<uint, object?> List = new ();

    /// <summary>
    /// Adds a new value to the list.
    /// </summary>
    /// <param name="value">The value to add.</param>
    internal static void Add(uint value)
    {
        List.TryAdd(value, null);
    }

    /// <summary>
    /// Removes all values from the list.
    /// </summary>
    internal static void Clear()
    {
        List.Clear();
    }
    
    /// <summary>
    /// Determines whether the list contains the specified value.
    /// </summary>
    /// <param name="value">The value to locate.</param>
    /// <returns>True if the list contains the specified value, otherwise false.</returns>
    public static bool Contains(uint value)
    {
        return List.ContainsKey(value);
    }
}