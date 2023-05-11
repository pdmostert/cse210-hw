/* The Journal class represents a journal object that can add entries, track whether it has been saved,
and return a read-only list of entries. */
public class Journal
{
    private bool _isSaved  = false;
    private List<Entry> _entries  = new();
    public Journal()
    {
    }
    public Journal(List<Entry> entries)
    {
        _entries = entries;
    }

/// <summary>
/// The function adds a new entry to a journal and sets a flag indicating that the journal has not been
/// saved.
/// </summary>
/// <param name="Entry">Entry is a class or data type that represents a journal entry. It could contain
/// properties such as the date, title, content, author, etc. The AddJournalEntry method takes an
/// instance of the Entry class as a parameter and adds it to a list of entries (_entries). It also sets
/// a</param>
    public void AddJournalEntry(Entry entry)
    {
        _entries.Add(entry);
        _isSaved = false;
    }
    public bool IsSaved
    {
        get { return _isSaved; }
    }
    public  IReadOnlyList<Entry> Entries
    {
        get { return _entries; }
    }

/// <summary>
/// The function sets a boolean variable to true indicating that a journal has been saved.
/// </summary>
    public void JournalSaved()
    {
        _isSaved = true;
    }

/// <summary>
/// The function returns a string indicating whether the object has been saved or not.
/// </summary>
/// <returns>
/// The method `Status()` returns a string indicating whether the object has been saved or not. If
/// `_isSaved` is true, it returns the string "(Saved)", otherwise it returns the string "(Not Saved)".
/// </returns>
    public string Status()
    {
        if (_isSaved)
        {
            return "(Saved)";
        }
        else{
            return "(Not Saved)";
        }
    }
    public void Load(List<Entry> entries){
        _entries = entries;
    }
}