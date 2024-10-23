using System;

public class Activity
{
    private string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n \n{_description}.\n");  
        
        Console.Write("How long in seconds would like for this activity?: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        Console.Write("Returning to the main menu: ");
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
            Thread.Sleep(700);
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