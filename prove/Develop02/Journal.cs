using System.IO;
public class Journal

{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        // where we are to add the entry to our list. kind of like append in python, etc.
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        // display all of our collected entries
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SavetoFile(string file)
    {
        // save entries method. 

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(
                    $"{entry._date}~|~{entry._mood}~|~{entry._promptText}~|~{entry._entryText}"
                );
            }
        }
    }

    public void LoadFromFile(string file)
    {
        // load entries
    }
}