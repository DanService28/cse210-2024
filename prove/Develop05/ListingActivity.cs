using System;
using System.Reflection.Metadata;

public class ListingActivity : Activity
{
    private int _count = 0;
    protected List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your " +
    "life by having you list as many things as you can in a certain area.")
    {
    }

    public List<string> GetListFromUser()
    {
        List<string> user = new List<string>();
        Console.Write("*");
        string thought = Console.ReadLine();
        user.Add(thought);
        _count++;

        return user;
    }

    public void GetRamdonPrompt()
    {   
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"--- {prompt} ---");
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Get Ready.");
        ShowSpinner(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        GetRamdonPrompt();

        while(DateTime.Now < endTime)
        {
            GetListFromUser();
        }
        Console.WriteLine($"You listed {_count} items. \n");

        DisplayEndingMessage();
        ShowSpinner(5);
    }
}