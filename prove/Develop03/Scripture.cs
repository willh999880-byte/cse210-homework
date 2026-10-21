using System.Timers;

class Scripture
{
    List<Word> _words;
    //TODO Add scripture reference

    public Scripture(string Book_Name, int chapter, int verse, string text)
    {
        //TODO 

    }

    public Scripture(string Book_Name, int chapter, int start_verse, int End_verse, string text)
    {
        //TODO 
        
    }

   private List<Word> ConvertTowords(string text)
    {
        List<Word> tempwords = new List<Word>();
        foreach(string word in text.Split(" "))
        {
            Word tempword = new Word(word);
            tempwords.Add(tempword);

        
        }
        return tempwords;
    }
}