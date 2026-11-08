class ListingActivity : Activity
{
    public ListingActivity() : base("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") 
    {
    
    }


    public void RunActivity()
    {
      StartActivity();   
         while (!HasTimerExpired())
        {
           RunCountDownMessage("Breathe in . . . ", 4);
            
           RunCountDownMessage("Breathe out . . . ", 6);
       }
      Console.Clear();
      EndActivity();
    }


    public void SetPrompts()
    {
     
    List<string> _prompts = new List<string>()
    {
      "Who are people that you appreciate?",
      "What are personal strengths of yours?",
      "Who are people that you have helped this week?",
      "When have you felt the Holy Ghost this month?",
      "Who are some of you personal heroes?"
    };
   
    }

}