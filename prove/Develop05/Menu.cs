class Menu
{
    int user_input;
    
    public Menu()
    {
      
    }

    public void RunMenu()
    {
         Goals creatingnewgoal = new Goals();
        user_input = 0;
        

        while(user_input != 6)
        {
            Console.WriteLine("Menu Options: ");
            Console.Write("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit\n");
             user_input = int.Parse(Console.ReadLine());

             if (user_input == 1)
            {
                
                creatingnewgoal.CreateGoal();
            }

            else if(user_input == 2)
            {
             creatingnewgoal.DisplayGoals();
             creatingnewgoal.DisplayPoints();
            }
            else if(user_input == 3)
            {
                
                creatingnewgoal.Savegoals();
            }

            else if (user_input == 4)
            {
                
                creatingnewgoal.Loadgoals();
                
            }
            else if (user_input == 5)
            {
            
                creatingnewgoal.RecordEvent(); 
            }

           
        }
    }
}