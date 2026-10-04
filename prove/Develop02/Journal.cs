public class journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        // where we are to add the entry to our list. kind of like append in python, etc.
        _entries.Add(entry);
    }

    public void DisplayAll();
    {
        // display all of our collected entries
    }

    public void SavetoFile(string file)
    {
        // save entries
    }

    public void LoadFromFile(string file)
    {
        // load entries
    }
}