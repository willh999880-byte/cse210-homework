using System.Security.Cryptography.X509Certificates;

class JournalEntry
{
    public string _date; 
    public string _prompt;
    public string _response;

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date}. ");
        Console.WriteLine($"{_prompt}. ");
        Console.WriteLine($"{_response}. ");//.Writeline command leaves the cursor on the newline/next line
    }

    public void CreateJournalEntry()
    {
        string [] prompts =
        {
            "How was your Day?",
            "How have you seen the Lord's hand in your life today?",
            "What would you like to do better tomorrow?",
            "What tender mercy from the Lord are you thankful for today?"
        };

        DateTime thecurrenttime = DateTime.Now;
        _date = thecurrenttime.ToShortDateString();
        _prompt = prompts[0];
         
        Console.Write($"{_prompt}"); //.Write command Leaves the cursor next to the line
        _response = Console.ReadLine(); //Reads everything you wrote to the line
    }

}