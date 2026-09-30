public class Job
{
 public string  _job_Title;

 public string _company;
 public int _start_Year;
 public int _end_Year;

 public void job_display()
    {
        Console.WriteLine($"{_job_Title} {_start_Year} - {_end_Year}");
    }
}

