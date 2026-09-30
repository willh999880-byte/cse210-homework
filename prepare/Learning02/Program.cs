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
        
        Job job2 = new Job();
        job2._job_Title = "Electrical Engineer";
        job2._company = "NASA";
        job2._start_Year = 1964;
        job2._end_Year = 1971;


        job1.Job_Display();
        job2.Job_Display();
    }
}