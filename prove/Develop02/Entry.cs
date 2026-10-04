

public class Entry
{
    // where we declare the strings and of course the types as well...
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood;

    public void Display ()
    {
        // where we will display the journal entry inside the terminal.
        Console.WriteLine($"Date : {_date} - Mood: {_mood}");
        Console.WriteLine($"Prompt : {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }
}