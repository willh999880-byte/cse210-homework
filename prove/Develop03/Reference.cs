class Reference
{
   private string _Book;
    private int _Chapter;
    private int[] _Verse;


    
    public Reference()
    {
        //
    }

    public Reference(string Book, int Chapter, int[] Verse)
    {
        _Book=Book;
        _Verse=Verse;
        _Chapter = Chapter;
    }

    public void DisplayReference()
    {
        Console.WriteLine($"{_Book} {_Chapter}: {_Verse}");
    }
}