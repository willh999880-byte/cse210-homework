using System;
using System.IO; 
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        JournalEntry NewEntry = new JournalEntry(); 
        Journal Save_Load_display_journal = new Journal();

         int response = 0;
         

        while (response != 5)
        {
            response = myMenu.ProcessMenu();
            switch (response)
            {
                case 1:
                  Console.WriteLine("create");
                  Save_Load_display_journal.CreateEntry();
                   break;
                case 2: 
                  Console.WriteLine("Display");
                  Save_Load_display_journal.DisplayJournal();
                    break;
                case 3:
                  Console.WriteLine("Save");
                  Console.WriteLine("Please enter the file you would like to save to:");
                  string filename = Console.ReadLine();
                  
                    break;
                case 4:
                  Console.WriteLine("Load");
                  Console.WriteLine("Please enter the file you would like to save to:");
                  filename = Console.ReadLine();
                  Save_Load_display_journal.LoadJournal(filename);
                    break;

            }
        }

    }
}