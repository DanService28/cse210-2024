using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Sofware Engineer";
        job1._company = "Samsung";
        job1._startYear = 2018;
        job1._endYear = 2023;

        

        job1.Display();
        Console.WriteLine();

        Job job2 = new Job();

        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2012;
        job2._endYear = 2016;

        job2.Display();
        Console.WriteLine();


        Resume myResume = new Resume();
        myResume._name = "Daniel Herrera";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        //string displayItem = myResume._jobs[1]._jobTitle;
        //Console.WriteLine(displayItem);

        myResume.DisplayResume();
    }
}