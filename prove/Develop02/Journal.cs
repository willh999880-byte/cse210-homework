using System.IO;
class Journal

{
    public List<JournalEntry>  _entries;

    
    public void DisplayJournal()
    {
        

    foreach ( JournalEntry entry in _entries)
    {
        entry.DisplayEntry();
    }
    }
    public void SaveJournal()
    {
        string filename = Console.ReadLine();

        using (StreamWriter outputfile = new StreamWriter(filename))

        {
            outputfile.WriteLine();

            foreach (JournalEntry entry in _entries)
            {
                outputfile.WriteLine(entry);
            }

            
        }
    }
    public void LoadJournal()
    {
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string date = parts[0];
            string entry = parts[1];
        }
    }
}