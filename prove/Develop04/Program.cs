using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        
       
        int Users_choice = 10000;
        
        Activity activity = new Activity("Breathing Activity", " Get ready to breathe");
        BreathingActivity startbreathing = new BreathingActivity();

        

        activity.DisplayWelcome();
        
        while(Users_choice != 0)
        {
            
            //TODO Add menu for activities
            Users_choice = int.Parse(Console.ReadLine());

            if(Users_choice == 1)
            {
                
                startbreathing.RunActivity();
                
                
            }
        }

        
        

        DateTime endtime = DateTime.Now.AddSeconds(15);

        

    }
}