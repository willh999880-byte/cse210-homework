using System;

class Program
{
    static void Main(string[] args)
    {
        BaseGoal goal_name = new BaseGoal(); 
        Console.WriteLine(goal_name.GetConsoleString());
    }
}