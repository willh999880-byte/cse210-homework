public class ChecklistGoal: BaseGoal
{

    private int _DurationOfGoal;
    private int _Times_Completed;
    private int _Bonus;


    public ChecklistGoal(): base("ChecklistGoal")
    {
        SetBonus();
        SetDuration();
    }
    public ChecklistGoal(string name, string description, int points, bool status,string goalType,int bonus,int timescompleted,int durationofgoal) : base(name,description,points,status,goalType)
    {
        _DurationOfGoal = durationofgoal;
        _Times_Completed = timescompleted;
        _Bonus = bonus;
    }

    public void SetBonus()
    {
        Console.WriteLine("How many bonus points would you like? ");
        _Bonus = int.Parse(Console.ReadLine());
    }

    public void SetDuration()
    {
        Console.WriteLine("How often would you like to get bonus points for completion? ");
        _DurationOfGoal = int.Parse(Console.ReadLine());
        while (_DurationOfGoal < 1)
        {
            Console.WriteLine("Invalid input");
            Console.WriteLine("Please try again.");
            _DurationOfGoal = int.Parse(Console.ReadLine());

        }

            
        
        
    
    }

    public override string Getfilestring()
    {
         string outputstring = "";

        outputstring = ($"{Goaltype}|{Completed}|{Name}|{Description}|{Points}|{_Bonus}|{_Times_Completed}|{_DurationOfGoal}");
        return outputstring;
    }

    public override int Getpoints()
    {
    
            int Total_bonus = 0;
            Total_bonus = (_Times_Completed/_DurationOfGoal) * _Bonus;
            int total_Points = _Times_Completed * Points;
            return total_Points + Total_bonus;
    
    }

     public override string GetConsoleString()
    {
        string completestring = " ";
        if (Completed)
            completestring = "x";
        return $"[{completestring}] - Goal Name: {Name}, Goal Description: {Description}, points: {Points} times completed: {_Times_Completed}/{_DurationOfGoal}";
    }


    public override int RecordEvent()
    {
        return MarkComplete();    
    }
    public override int MarkComplete()
    {
        _Times_Completed += 1;

        if (_DurationOfGoal <= _Times_Completed)
        {
            return base.MarkComplete();
        }
            return Points;
    } 
}