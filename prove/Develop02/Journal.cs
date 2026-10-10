using System;
using System.IO; 
using System.Collections.Generic;

class Journal

{

     
    public List<JournalEntry> _entries = new List<JournalEntry>();
     
    
    public void DisplayJournal()
    {
        

    foreach ( JournalEntry entry in _entries)
    {
        entry.DisplayEntry();
    }
    }


    public void CreateEntry()
    {
        
        JournalEntry newEntry = new JournalEntry();
        newEntry.CreateJournalEntry();
        _entries.Add(newEntry);

    }
    
    public void SaveJournal(string filename)
    {
        Console.Write("Please enter the file where you want to save your journal: ");
        
        using (StreamWriter outputfile = new StreamWriter(filename))

        {
        
            foreach (JournalEntry entry in _entries)
            {
                outputfile.WriteLine(entry.CreateSystemString());
            }

            
        }
        
    }

    public void LoadJournal(string filename)
    {
        
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            
           
        }

    }


}