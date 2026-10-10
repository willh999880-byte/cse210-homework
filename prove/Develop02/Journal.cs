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
    public void SaveJournal()
    {
        Console.Write("Please enter the file where you want to save your journal: ");
        
        string filename = Console.ReadLine();
        
        using (StreamWriter outputfile = new StreamWriter(filename))

        {
        
            foreach (JournalEntry entry in _entries)
            {
                outputfile.WriteLine(entry);
            }

            
        }
        
    }

    public void LoadJournal()
    {
        Console.Write("Please enter the file where you have your journal: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string entry = parts[0];
            Console.WriteLine($"{entry}");
        }
    }
}