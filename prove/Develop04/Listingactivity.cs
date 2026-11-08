class ListingActivity : Activity
{
    List<string> _prompts; 

    public ListingActivity() : base("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") 
    {
        
    }


    public void RunActivity()
    {
      StartActivity();   
      SetPrompts();
         while (!HasTimerExpired())
        {
           Random random= new Random();
           int random_index = random.Next(_prompts.Count); 
           string random_prompt =_prompts[random_index];
           
           RunCountDownMessage("Get ready...", 5);
           Console.WriteLine(random_prompt);
           Console.WriteLine("Now enter as many answers to the previous question as you can!");
            int number_of_answers = 0;
            while (!HasTimerExpired())
            {
                
                Console.Read();
                number_of_answers += 1;
                
            }
       }
      Console.Clear();
      EndActivity();
    }


    public void SetPrompts()
    {
     
     _prompts = new List<string>()
    {
      "Who are people that you appreciate?",
      "What are personal strengths of yours?",
      "Who are people that you have helped this week?",
      "When have you felt the Holy Ghost this month?",
      "Who are some of you personal heroes?"
    };
    
    }

    public void ResetPrompts()
    {
        SetPrompts();
    }

}