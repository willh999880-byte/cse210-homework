public class Job
{
 public string  _job_Title = "";
 public int _start_Year;
 public int _end_Year;

 public static void job_display(string _job_Title, int _start_Year, int _end_Year)
    {
        Console.WriteLine($"Job Title {_job_Title} {_start_Year} - {_end_Year}");
    }
}

