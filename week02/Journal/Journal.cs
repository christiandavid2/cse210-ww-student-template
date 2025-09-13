public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry Entry)
    {
        _entries.Add(Entry);
    }
    public void displayall()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No Journal entries yet");
            return;
        }
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void savetofile( string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach(Entry entry in _entries) 
            {
                writer.WriteLine(entry.ToFileFormat());
            }
        }
    }
    public void loadfromfile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                _entries.Add(new Entry(line));
            }
            Console.WriteLine("Journal loaded successfully");
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }
}