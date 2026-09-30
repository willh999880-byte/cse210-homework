using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._job_Title = "Software Engineeer (Microsoft)";
        job1._start_Year = 2019;
        job1._end_Year = 2022;
        
        string full_job1 = job_display(job1._job_Title, job1._start_Year, job1._end_Year);
    }
}