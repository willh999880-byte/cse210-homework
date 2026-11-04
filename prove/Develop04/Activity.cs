class Activity
{
    string _name;


    public Activity()
    {
        //TODO Fill in 
    }
    
    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for (int i=seconds; i>=0; i--)
        {
          Console.Clear();  
          Console.Write($"{message} - {i}");
          Thread.Sleep(1000);   
        }
        Console.CursorVisible = true;
           
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

}