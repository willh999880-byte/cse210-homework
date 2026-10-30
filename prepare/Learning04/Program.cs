using System;

class Program
{
    static void Main()
    {
       Assignment newassignment = new Assignment(); 
       string mysummary =  newassignment.GetSummary("Samuel","Division");

       Console.WriteLine(mysummary);
    }
}