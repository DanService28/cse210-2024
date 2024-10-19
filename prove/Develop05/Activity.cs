using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n \n{_description}.");  
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    }

    public void ShowSpinner (int seconds)
    {
        List<string> spinner = new List<string>();
        string[] characters = {"|", "/", "-", "\\", "|", "/", "-", "\\"};

        spinner.AddRange(characters);
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        int i = 0;

        while(DateTime.Now < endTime)
        {
            string spin = spinner[i];
            Console.Write(spin);
            Thread.Sleep(900);
            Console.Write("\b \b");

            i++;

            if(i >= spinner.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        
        for(int i = seconds ; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}