class Activity
{
    private string _Name;

    private string _UserName;
    private int _Duration;
    private string _Description;
    private DateTime _endtime;






       public Activity()
    {
       
    }

       public Activity(string name, string Description)
    {
        _Name = name;

        _Description = Description;

    }



public void StartTimer()
    {
        _endtime = DateTime.Now.AddSeconds(_Duration);
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now > _endtime;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_Name}, {_Description}");
        GetDuration();

        
    }

    public void GetUserName()
    {
        Console.Write("Please enter your name: ");
        _UserName = Console.ReadLine();
    } 
  
    
    public void RunCountDownMessage(string message, int seconds)
    {
        
        for (int i=seconds; i>=0; i--)
        {
          Console.Clear();  
          Console.Write($"{message} - {i}");
          Thread.Sleep(1000);   
        }
        
           
    }
    public void DisplaySpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        Console.Clear();
        Console.Write($"{message} ");
        DateTime endtime = DateTime.Now.AddSeconds(seconds);


        while (DateTime.Now < endtime)
        {
            
            Console.Write("+");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
        }
        Console.CursorVisible = true;
    }

    public void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Mindfulness program.");
        Console.Write("Please choose what activity you would like to do: ");
    }

    private void GetDuration()
    {
        Console.WriteLine("How long would you like the activity to last? ");
        _Duration = int.Parse(Console.ReadLine());
        
    }

}