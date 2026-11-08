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
        ListingActivity startlisting = new ListingActivity();
        ReflectionActivity startreflecting = new ReflectionActivity(); 

        

        activity.DisplayWelcome();

        while(Users_choice != 0)
        {
            
            Console.WriteLine("\n1.Breathing Activity \n2.Reflection Activity \n3.Listing Activity");
            Users_choice = int.Parse(Console.ReadLine());

            if(Users_choice == 1)
            {
                
                startbreathing.RunActivity();
            }

            else if(Users_choice == 2)
            {
                startreflecting.RunActivity();
            }
            else if (Users_choice == 3)
                {
                    startlisting.RunActivity();
                }
            else {
                Console.WriteLine("Thank you for using the program and stay mindful!");
            }
            
        }

        
        

        DateTime endtime = DateTime.Now.AddSeconds(15);

        

    }
}