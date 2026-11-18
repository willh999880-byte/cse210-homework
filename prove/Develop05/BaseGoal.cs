using System.Collections.Concurrent;
using System.Net;
using System.Runtime.CompilerServices;

class BaseGoal
{

    private string _name;

    private string _description;

    private int _points;

    private bool _status;

    private string _goalType;


    public BaseGoal(string name, string description, int points, bool status,string goalType )
    {
         _name = name;
         _description = description;
         _points = points;
         _status = status;
         _goalType = goalType;

    }
    public BaseGoal()
    {
         SetGoalName();
         SetGoalDescription();
         SetGoalPoints();

    }

    private void SetGoalName()
    {
        Console.Write("Please enter the name of your goal: ");
        _name = Console.ReadLine();
    }

    private void SetGoalDescription()
    {
        Console.Write("Please enter the description of said goal: ");
        _description = Console.ReadLine();
    }

     private void SetGoalPoints()
    {
        Console.Write("Please enter the number of points for said goal: ");
        _points = int.Parse(Console.ReadLine());
    }


    public virtual string GetConsoleString()
    {
        return $"[ ] - Goal Name: {_name}, Goal Description: {_description}, points: {_points}";
        
    }

}