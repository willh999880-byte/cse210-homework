using System.IO;
class Goals
{
    List<BaseGoal> _goals;
    string _filename;


    public Goals()
    {
       Getfilename();
       _goals = new List<BaseGoal>();
    

    }

    public void Getfilename()
    {
        Console.WriteLine("Please enter the file you want: ");
        _filename = Console.ReadLine();
    }

    public void Savegoals()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
        // You can add text to the file with the WriteLine method
        foreach(BaseGoal Goal in _goals)
            {
         outputFile.WriteLine(Goal.Getfilestring());
            }
        }
    }

    public void Loadgoals()
    {
        //TODO
    }


    public void DisplayGoals()
    {
        foreach (BaseGoal Goal in _goals)
        {
          Console.WriteLine(Goal);   
        }
    }

    public void DisplayPoints()
    {
        //TODO
    }

    public void CreateGoal()
    {
        int user_input_2 = 0;

        Console.WriteLine("The types of goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\nWhich type of goal would you like to create? ");
                user_input_2 = int.Parse(Console.ReadLine());

                if(user_input_2 == 1)
                {
                    SimpleGoal mysimplegoal = new SimpleGoal();
                    Console.WriteLine(mysimplegoal.GetConsoleString());
                }
                else if (user_input_2 == 2)
                {
                    // EternalGoal myeternalgoal = new EternalGoal();
                    // Console.WriteLine(myeternalgoal.GetConsoleString());
                }

                else if (user_input_2 == 3)
                {
                    // ChecklistGoal mychecklistgoal = new ChecklistGoal();
                    // Console.WriteLine(mychecklistgoal.GetConsoleString());
                }
    }

    public void RecordEvent()
    {
        
    }
}