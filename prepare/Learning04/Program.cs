using System;

class Program
{
    static void Main()
    {
       Assignment newassignment = new Assignment("Samuel", "Multiplication"); 
       MathAssignment newmath = new MathAssignment("Samuel", "Multiplication", "10", "10-11");

       Console.WriteLine(newassignment.GetSummary());
       Console.WriteLine(newmath.GetHomeworkList());
       Console.WriteLine(newassignment.GetSummary());
    }
}