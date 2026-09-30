using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._job_Title = "Software Engineeer";
        job1._company = "Microsoft";
        job1._start_Year = 2019;
        job1._end_Year = 2022;
        
        job1.job_display();
    }
}