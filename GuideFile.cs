using System;
using System.IO;

/// <summary>
/// Helper to create and copy a simple guide file used by the Program.
/// </summary>
public static class GuideFile
{
    public const string DefaultFileName = "guide.txt";

    public static void CreateDefaultGuide(string directory = null)
    {
        var dir = string.IsNullOrEmpty(directory) ? Environment.CurrentDirectory : directory;
        var path = Path.Combine(dir, DefaultFileName);

        var lines = new[]
        {
            "The loose guide of running",
            "Drink plenty of water throughout the day to make sure your performance is best",
            "Understanding the effects of the sun is valid, because heat stroke is real",
            "Waking up early is a factor in how your performance shows.",
            "Make running fun for you and your friends by working together to achieve fitness"
        };

        File.WriteAllLines(path, lines);
    }

    /// <summary>
    /// Copies the default guide file to a destination path. Uses the safe File.Copy overload.
    /// </summary>
    /// <param name="destinationPath">Destination file path.</param>
    /// <param name="overwrite">Whether to overwrite an existing file at the destination.</param>
    public static void CopyDefaultGuide(string destinationPath, bool overwrite = false)
    {
        var sourcePath = Path.Combine(Environment.CurrentDirectory, DefaultFileName);
        if (!File.Exists(sourcePath)) throw new FileNotFoundException("Source guide file not found.", sourcePath);

        // Correct File.Copy usage with overwrite parameter
        File.Copy(sourcePath, destinationPath, overwrite);
    }
}
