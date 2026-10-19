class Word
{
    private string _word;
    
    private bool _hidden;


    public Word(string Word)
    {
        _word = Word;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public void Display()
    {
        Console.Write($"{Get_Word_String()} ");
    }
    
    public string Get_Word_String()
    {
        string returnstring = "";
        if (_hidden)
            for (int i = 0; i < _word.Length; i++)
            {
                returnstring += ("_");
            }
        else
        {
            returnstring = _word;
        }
        return returnstring;
    }
}