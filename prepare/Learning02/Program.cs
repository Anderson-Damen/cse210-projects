using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2024;
        job1._endYear = 2028;

        job1 job2 = new Job();
        job2._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Damen Anderson";

        myResume._jobs.Add(jobs1);
        myResume._jobs.Add(jobs2);

        myResume.Display();
    }
}