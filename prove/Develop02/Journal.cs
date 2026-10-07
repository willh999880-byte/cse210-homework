using System.IO;
class Journal

{
    public List<JournalEntry>  _entries;

    string filename = "Myjournal.txt";
    public void DisplayJournal()
    {
        

    foreach ( JournalEntry entry in _entries)
    {
        entry.DisplayEntry();
    }
    }
    public void SaveJournal()
    {
        using (StreamWriter outputfile = new StreamWriter(filename))
        
        {
            outputfile.WriteLine();

            
        }
    }
    public void LoadJournal()
    {
        
    }
}