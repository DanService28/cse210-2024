using System;

class Program
{
    static void Main(string[] args)
    {
        Activity newActivity = new Activity("Math","Fractions with you", 18);
        newActivity.DisplayStartingMessage();
        
        newActivity.DisplayEndingMessage();
        newActivity.ShowCountDown(5);
        
    }
}