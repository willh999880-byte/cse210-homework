class BaseGoal
{

    private string _name;

    private string _Description;

    private int _Points;
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
        _Description = Console.ReadLine();
    }

     private void SetGoalPoints()
    {
        Console.Write("Please enter the number of points for said goal: ");
        _Points = int.Parse(Console.ReadLine());
    }


    public virtual string GetConsoleString()
    {
        return $"Goal Name: {_name}, Goal Description: {_Description}, points: {_Points}";
        
    }

}