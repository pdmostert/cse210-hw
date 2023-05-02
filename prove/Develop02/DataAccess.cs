using System.IO;
/* The `DataAccess` class provides methods for reading and writing journal and prompt files in a
specific format. */
public static class DataAccess
{

    /// <summary>
    /// The function reads a file and returns a list of entries, where each entry contains a date, prompt,
    /// and response.
    /// </summary>
    /// <param name="fileName">The name of the file that needs to be read.</param>
    /// <returns>
    /// The method `ReadFile` returns a `List` of `Entry` objects.
    /// </returns>
    public static List<Entry> ReadJournalFile(string fileName)
    {
        List<Entry> entries = new();
        string[] lines = File.ReadAllLines(fileName);
        foreach (var line in lines)
        {
            string[] parts = line.Split("~|~");
            entries.Add(new Entry(parts[0], parts[1], parts[2] ));
        }
        return entries;
    }

    /// <summary>
    /// The function writes a list of entries to a file in a specific format.
    /// </summary>
    /// <param name="fileName">A string representing the name of the file to be written to.</param>
    /// <param name="entries">A list of objects of type "Entry". Each "Entry" object contains a date, a
    /// prompt, and a response.</param>
    public static void WriteJournalFile(string fileName, Journal journal)
    {
        using StreamWriter outputfile = new StreamWriter(fileName);
        foreach (var item in journal.Entries)
        {
            outputfile.WriteLine($"{item.Date}~|~{item.Prompt}~|~{item.Response}");
        }
        journal.JournalSaved();
    }


/// <summary>
/// The function reads a file containing prompts and returns a list of the prompts.
/// </summary>
/// <param name="fileName">The name of the file that contains the prompts to be read.</param>
/// <returns>
/// The method is returning a list of strings containing the prompts read from a file. If the file is
/// not found, an empty list is returned.
/// </returns>
    public static List<string> ReadPromptFile(string fileName)
    {
            List<string> prompts = new();
        try
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                string[] parts = line.Split("~|~");
                prompts.Add(parts[0]);
            }
            return prompts;
        }
        catch (FileNotFoundException)
        {
            prompts = new();
            return prompts;
        }
    }

/// <summary>
/// The function writes a list of prompts to a file with the given file name.
/// </summary>
/// <param name="fileName">A string representing the name of the file to be created or overwritten with
/// the prompts.</param>
/// <param name="prompts">A list of strings containing the prompts to be written to the file.</param>
    public static void WritePromptFile(string fileName, List<string> prompts)
    {
        using StreamWriter outputfile = new StreamWriter(fileName);
        foreach (var item in prompts)
        {
            outputfile.WriteLine(item);
        }
    }

}