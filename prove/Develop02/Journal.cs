public class Journal
{

    public bool IsSaved { get; private set; } = false;
    public List<Entry> Entries { get; private set; } = new();

    public Journal()
    {
    }
    public Journal(List<Entry> entries)
    {
        Entries = entries;
    }
    public void AddJournalEntry(Entry entry)
    {
        Entries.Add(entry);
        JournalSaved(false);

    }
    public void JournalSaved(bool isSaved)
    {
        IsSaved = isSaved;
    }
    public string Status()
    {
        if (IsSaved)
        {
            return "(Saved)";
        }
        else{
            return "(Not Saved)";
        }

    }
}