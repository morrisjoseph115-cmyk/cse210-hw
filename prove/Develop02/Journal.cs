using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // Cipher object for encrypting and decrypting journal files.
    private Cipher _cipher = new Cipher();

    public void AddEntry(Entry entry)
    {
        // Add an entry to our list.
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        // Display all collected entries.
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SavetoFile(string file, bool encrypt = true)
    {
        // Save entries with optional Caesar encryption.

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            if (encrypt)
            {
                outputFile.WriteLine("#CAESAR3");
            }

            foreach (Entry entry in _entries)
            {
                string line = $"{entry._date}~|~{entry._mood}~|~{entry._promptText}~|~{entry._entryText}";

                if (encrypt)
                {
                    line = _cipher.Encrypt(line);
                }

                outputFile.WriteLine(line);
            }
        }
    }

    public void LoadFromFile(string file)
    {
        // Load entries and automatically decrypt when necessary.

        _entries.Clear();

        string[] lines = File.ReadAllLines(file);

        bool encrypted = lines.Length > 0 && lines[0] == "#CAESAR3";

        for (int i = encrypted ? 1 : 0; i < lines.Length; i++)
        {
            string line = lines[i];

            if (encrypted)
            {
                line = _cipher.Decrypt(line);
            }

            string[] parts = line.Split("~|~");

            Entry entry = new Entry();

            entry._date = parts[0];
            entry._mood = parts[1];
            entry._promptText = parts[2];
            entry._entryText = parts[3];

            _entries.Add(entry);
        }
    }
}