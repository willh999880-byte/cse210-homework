using System.Runtime.InteropServices;

class SimpleGoal : BaseGoal
{
    public SimpleGoal(): base("simplegoal")
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
        //TODO
        return "";
    }

  
}