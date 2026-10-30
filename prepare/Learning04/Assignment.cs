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

    public string GetStudentName()
    {
        return _StudentName;
    }

    public string GetTopic()
    {
        return _Topic;
    }
    public string GetSummary()
    {   
    
        return $"{_StudentName} - {_Topic}";
    }

}