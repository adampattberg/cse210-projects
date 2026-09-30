using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2024;
        job1._endYear = 2026;
        job1.DisplayJob();


        Job job2 = new Job();
        job2._company = "Hunter Engineering";
        job2._jobTitle = "Test Engineering Co-Op";
        job2._startYear = 2026;
        job2._endYear = 2026;
        job2.DisplayJob();

        Console.WriteLine ("");

        Resume myResume = new Resume();
        myResume._name = "Adam Pattberg";
        myResume._job.Add(job1);
        myResume._job.Add(job2);
        myResume.DisplayResume(); 
    }
}