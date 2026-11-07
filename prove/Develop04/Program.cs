using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        
       
        int Users_choice = 10000;
        Activity activity = new Activity("Breathing Activity", " Get ready to breathe");

        

        while(Users_choice != 0)
        {
            activity.DisplayWelcome();
            //TODO Add menu for activities
            Users_choice = int.Parse(Console.ReadLine());
        }

        
        activity.RunCountDownMessage("Get Ready", 5);
        activity.DisplaySpinnerMessage("Well Done",10);

        DateTime endtime = DateTime.Now.AddSeconds(15);

        

        //while (DateTime.Now < endtime)
        //{
          //  activity.RunCountDownMessage("Breathe in . . . ", 4);
            
           // activity.RunCountDownMessage("Breathe out . . . ", 6);
       // }
    }
}