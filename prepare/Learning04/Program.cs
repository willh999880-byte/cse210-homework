using System;

class Program
{
    static void Main()
    {
       Assignment newassignment = new Assignment("Samuel", "Multiplication"); 
       MathAssignment newmath = new MathAssignment("Samuel", "Multiplication", "10", "10-11");
       WritingAssignment newwriting = new WritingAssignment("Samuel", "World War 2", "The Great Calamity");


       Console.WriteLine(newassignment.GetSummary());
       Console.WriteLine(newmath.GetHomeworkList());
       Console.WriteLine(newassignment.GetSummary());

       Console.WriteLine(newwriting.GetSummary());
       Console.WriteLine(newwriting.GetWritingInformation());
    }
}