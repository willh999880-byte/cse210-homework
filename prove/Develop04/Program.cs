using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        //activity.RunCountDownMessage("Get Ready", 5);
        activity.DisplaySpinnerMessage("Well Done",10);

        DateTime endtime = DateTime.Now.AddSeconds(15);

        while (DateTime.Now < endtime)
        {
            activity.RunCountDownMessage("Breathe in . . . ", 4);
            activity.RunCountDownMessage("Breathe in . . . ", 6);
        }
    }
}