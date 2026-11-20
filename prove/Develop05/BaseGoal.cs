using System.ComponentModel.DataAnnotations.Schema;

public abstract class BaseGoal
{

    private string _name;

    private string _description;

    private int _points;

    private bool _completed;

    private string _goalType;

    public bool Completed => _completed;
    public string Name => _name;
    public string Description => _description;
    public int Points => _points;

    public string Goaltype => _goalType;

    public BaseGoal(string name, string description, int points, bool status,string goalType)
    {
         _name = name;
         _description = description;
         _points = points;
         _completed = status;
         _goalType = goalType;


    }
    public BaseGoal(string goalType)
    {
         SetGoalName();
         SetGoalDescription();
         SetGoalPoints();
         _completed = false;
         _goalType = goalType;

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
        string completestring = " ";
        if (_completed)
            completestring = "x";
        return $"[{completestring}] - Goal Name: {_name}, Goal Description: {_description}, points: {_points}";
        
    }

      public int MarkComplete()
    {
        _completed = true; 
        return _points;
    }

    public abstract int RecordEvent();

    public abstract string Getfilestring();

}