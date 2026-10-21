using System.Timers;

class Scripture
{
    List<Word> _words;
    //TODO Add scripture reference

    public Scripture(string Book_Name, int chapter, int verse, string text)
    {
        //TODO add scripture reference here use bookname, chapter, and verse to create scripture reference
        _words = ConvertToWords(text);

    }

    public Scripture(string Book_Name, int chapter, int start_verse, int End_verse, string text)
    {
        //TODO 
        
    }
    

    //
    //ConvetToWords will convert the paragraph that is in the text parameter to a list of words. The list of words is returned
   private List<Word> ConvertToWords(string text)
    {

        List<Word> tempwords = new List<Word>();

        string[] words = text.Split(" ");
        foreach(string word in words)
        {
            Word tempword = new Word(word);
            tempwords.Add(tempword);

        
        }
        return tempwords;
    }
}