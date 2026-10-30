class Assignment
{
    private string _StudentName;
    private string _Topic;


    public Assignment()
    {
        _StudentName = "Will";
        _Topic = "Math";
    }
    
    public Assignment(string name, string subject)
    {
        _StudentName = name;
        _Topic = subject;
    }

    public string GetSummary(string name, string Topic)
    {   
    
        return $"{name} - {Topic}";
    }

}