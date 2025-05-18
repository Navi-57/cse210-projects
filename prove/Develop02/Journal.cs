class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.\n");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        File.WriteAllLines(filename, entries.ConvertAll(e => e.ToFileFormat()));
        Console.WriteLine($"Journal saved to '{filename}'.\n");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"File '{filename}' not found.\n");
            return;
        }

        var lines = File.ReadAllLines(filename);
        entries.Clear();

        foreach (var line in lines)
        {
            var entry = Entry.FromFileFormat(line);
            if (entry != null)
            {
                entries.Add(entry);
            }
        }

        Console.WriteLine($"Journal loaded from '{filename}'.\n");
    }
}