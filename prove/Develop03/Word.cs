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
        Console.Write($"{_word} ");
    }
    
    public string Get_Word_String()
    {
        return _word;
    }
}