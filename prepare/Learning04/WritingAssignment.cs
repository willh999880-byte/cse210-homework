class WritingAssignment : Assignment
{
 private string _title;


   public  WritingAssignment(string StudentName,string Topic, string title) : base(StudentName, Topic)
    {
        _title = title;
    }

 public string GetWritingInformation()
    {
        return $"{_title} by {_StudentName}";
    }  
}