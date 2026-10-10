using System;

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
                  NewEntry.CreateJournalEntry();
                   break;
                case 2: 
                  Console.WriteLine("Display");
                  NewEntry.DisplayEntry();
                    break;
                case 3:
                  Console.WriteLine("Save");
                  Save_Load_display_journal.SaveJournal();
                    break;
                case 4:
                  Console.WriteLine("Write");
                  Save_Load_display_journal.LoadJournal();
                    break;

            }
        }

    }
}