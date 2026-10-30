using System;

class Program
{
    static void Main()
    {
       Assignment newassignment = new Assignment("Samuel", "Multiplication"); 
       

       Console.WriteLine(newassignment.GetSummary());
    }
}