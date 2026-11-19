using System;

class Program
{
    static void Main(string[] args)
    {
    
       
       Menu runmenu = new Menu();
       runmenu.RunMenu();
       SimpleGoal mysimplegoal = new SimpleGoal();
       Console.WriteLine(mysimplegoal.GetConsoleString());

       
    }
}