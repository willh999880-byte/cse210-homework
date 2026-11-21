using System.IO;
class Goals
{
    List<BaseGoal> _goals;
    string _filename;


    public Goals()
    {
       _goals = new List<BaseGoal>();
    

    }

    public void Getfilename()
    {
        Console.WriteLine("Please enter the file you want: ");
        _filename = Console.ReadLine();
    }

    public void Savegoals()
    {
        Getfilename();
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
        Getfilename();
         using (StreamReader inputFile = new StreamReader(_filename))
        {
            string new_line = inputFile.ReadLine();
        // You can load text from the file with the ReadLine method
        while(new_line != null)
            {
                
                string [] parts = new_line.Split("|");
                new_line = inputFile.ReadLine();

                
                if (parts[0] == "SimpleGoal")
                {
                    SimpleGoal recreategoal = new SimpleGoal(parts[2],parts[3],int.Parse(parts[4]),bool.Parse(parts[1]),parts[0]);
                    _goals.Add(recreategoal);
                    
                }

                else if (parts[0] == "EternalGoal")
                {
                   EternalGoal recreategoal = new EternalGoal(parts[2],parts[3],int.Parse(parts[4]),bool.Parse(parts[1]),parts[0]);
                   _goals.Add(recreategoal);   
                }

                else if(parts[0] == "ChecklistGoal")
                
                {
                 //ChecklistGoal recreategoal = new ChecklistGoal(parts[2],parts[3],int.Parse(parts[4]),bool.Parse(parts[1]),parts[0]);
                   // _goals.Add(recreategoal);   
                }
                
                
            }
        
        }
    }


    public void DisplayGoals()
    {
        int goal_number = 1;
        foreach (BaseGoal Goal in _goals)
        {
          Console.WriteLine($"{goal_number}. {Goal.GetConsoleString()}");  
          goal_number +=1;
        }
    }

    public void DisplayPoints()
    {
        int Totalpoints = 0;

        foreach(BaseGoal goal in _goals)
        {
            Totalpoints += goal.Getpoints();
            
        }
        Console.WriteLine($"You have {Totalpoints} total points!");
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
                    _goals.Add(mysimplegoal);
                }
                else if (user_input_2 == 2)
                {
                    // EternalGoal myeternalgoal = new EternalGoal();
                    // Console.WriteLine(myeternalgoal.GetConsoleString());
                    // _goals.Add(myeternalgoal);
                }

                else if (user_input_2 == 3)
                {
                    // ChecklistGoal mychecklistgoal = new ChecklistGoal();
                    // Console.WriteLine(mychecklistgoal.GetConsoleString());
                    // _goals.Add(mychecklistgoal);
                }   
    }

    public void RecordEvent()
    {
        foreach(BaseGoal goal in _goals)
        {
            goal.MarkComplete();
        }
        
    }

}