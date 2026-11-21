public class EternalGoal : BaseGoal
{

    public EternalGoal(string name, string description, int points, bool status,string goalType):base(name,description,points,status,goalType)
    {
        
    }
    public override int RecordEvent()
    {
       return MarkComplete();
    }

    public override int Getpoints()
    {
         if (Completed)
        {
          return Points;    
        }
        else
        {
        return 0; 
        }
    }

    public override string Getfilestring()
    {
        string outputstring = "";

        outputstring = ($"{Goaltype}|{Completed}|{Name}|{Description}|{Points}");
        return outputstring;
    }
}