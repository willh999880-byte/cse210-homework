using System.Timers;

class Scripture
{
    private List<Word> _words;
    private Reference _Scripturereference;

    private Random _random = new Random();

    public Scripture(string Book_Name, int chapter, int[] verse, string text)
    {
        _Scripturereference = new Reference(Book_Name, chapter, verse);
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


    public void ShowScripture()
    {
        _Scripturereference.DisplayReference();
        foreach(Word word in _words)
        {
            word.Display();
        }
    }

    public void Remove_Three_Words()
    {
       for (int i = 0; i < 3; i++)
       {
        
        int random_word_to_hide =_random.Next(_words.Count);
        
        if (!_words[random_word_to_hide].IsHidden())
            {
                _words[random_word_to_hide].Hide();
            }
            else
            {
                i--;
            }
        
       }
        

    }
}