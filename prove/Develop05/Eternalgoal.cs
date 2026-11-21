public class EternalGoal : BaseGoal
{

    private int times_completed; 

    public EternalGoal() : base("Eternalgoal")
    {
        
    }

    
        public EternalGoal(string name, string description, int points, bool status,string goalType,int timescompleted):base(name,description,points,status,goalType)
    {
        times_completed = timescompleted;
        
    }

    public override int MarkComplete()
    {
        times_completed += 1;
        return Points;   
    }
    public override int RecordEvent()
    {
    
       return MarkComplete();
    }

    public override int Getpoints()
    {  
       return Points*times_completed;    
    }

    public override string Getfilestring()
    {
        string outputstring = "";

        outputstring = ($"{Goaltype}|{Completed}|{Name}|{Description}|{Points}|{times_completed}");
        return outputstring;
    }

       public override string GetConsoleString()
    {
        string completestring = " ";
        if (Completed)
            completestring = "x";
        return $"[{completestring}] - Goal Name: {Name}, Goal Description: {Description}, points: {Points} times completed: {times_completed}";
        
    }
}