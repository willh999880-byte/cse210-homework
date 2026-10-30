class MathAssignment : Assignment
{
 private string _TextbookSection;
 private string _Problems;


public MathAssignment(string StudentName, string Topic, string Textbook, string Problems) : base(StudentName, Topic)
    {
        _TextbookSection = Textbook;
        _Problems = Problems;
    }

 public string GetHomeworkList()
    {
        return $"Section: {_TextbookSection} Problems: {_Problems}";
    }   
}