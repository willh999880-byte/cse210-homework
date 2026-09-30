public class Job
{
 public string  _job_Title;

 public string _company;
 public int _start_Year;
 public int _end_Year;

 public void Job_Display()
    {
        Console.WriteLine($"{_job_Title} {_company} {_start_Year} - {_end_Year}");
    }
}

