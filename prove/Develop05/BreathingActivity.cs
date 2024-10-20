using System;
using System.ComponentModel;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you" +
        "through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void BreathingAcrtivity()
    {
        Console.Write("Breathe in...");
        ShowCountDown(4);
        Console.WriteLine();
        Console.Write("Breathe out...");
        ShowCountDown(6);
        Console.WriteLine("\n");
    }

    public void Run()
    {
        int i  = 0;
        DisplayStartingMessage();

        Console.WriteLine("Get Ready.");
        ShowSpinner(5);
        Console.WriteLine();

        while(i < _duration)
        {
            BreathingAcrtivity();
            i += 10;
        }

        DisplayEndingMessage();
        ShowSpinner(5);
    }
}