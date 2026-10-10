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
        DateTime thecurrenttime = DateTime.Now;
        _date = thecurrenttime.ToShortDateString();
        _prompt = "How was you day?";
         
        Console.Write($"{_prompt}"); //.Write command Leaves the cursor next to the line
        _response = Console.ReadLine(); //Reads everything you wrote to the line
    }

}