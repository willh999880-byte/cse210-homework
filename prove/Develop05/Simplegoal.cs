using System.Runtime.InteropServices;

class SimpleGoal : BaseGoal
{
    public SimpleGoal(): base("SimpleGoal")
    {
        
    }
    

    public SimpleGoal(string name, string description, int points, bool status,string goalType):base(name,description,points,status,goalType)
    {
        
    }

    public override int RecordEvent()
    {
        return MarkComplete();
    }


    public override string Getfilestring() 
    {
        
        string outputstring = "";

        outputstring = ($"{Goaltype}|{Completed}|{Name}|{Description}|{Points}");
        return outputstring;

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

  
}