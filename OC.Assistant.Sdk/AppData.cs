namespace OC.Assistant.Sdk;

internal static class AppData
{
    private static readonly string PathPreset = 
        $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\OC.Assistant";

    /// <summary>
    /// Gets the path of the user-specific directory.
    /// </summary>
    public static string Path
    {
        get
        {
            Directory.CreateDirectory(PathPreset);
            return PathPreset;
        }
    }
}