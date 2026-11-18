class SimpleGoal : BaseGoal
{
    public SimpleGoal(): base()
    {
        
    }
    

    public SimpleGoal(string name, string description, int points, bool status,string goalType):base(name,description,points,status,goalType)
    {
        
    }

    public override int RecordEvent()
    {
        return 0;
    }
}