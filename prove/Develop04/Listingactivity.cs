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
        
           Random random= new Random();
           int random_index = random.Next(_prompts.Count); 
           string random_prompt =_prompts[random_index];
           RunCountDownMessage("Get ready...", 5);
           RunCountDownMessage($"\nList as many responses as you can to the following prompt:\n {random_prompt}\nYou may begin in:", 5);
          
           Console.WriteLine("");
           Console.WriteLine("Now enter as many answers to the previous question as you can!");
            int number_of_answers = 0;
            while (!HasTimerExpired())
            {
                
                Console.ReadLine();
                number_of_answers += 1;
                
            }
      Console.Clear();
      Console.WriteLine($"You listed {number_of_answers} items!");
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