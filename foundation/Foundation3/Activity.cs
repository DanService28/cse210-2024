using System;
using System.Diagnostics;

public abstract class Activity 
{
    protected string _date;
    protected double _length;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public abstract double GetDistance();
    
    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual void GetSummary()
    {
        Console.WriteLine($"{_date} {GetActivityType()} ({_length} min): Distance {GetDistance()} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace()} min per km");
    }

    public abstract string GetActivityType();
}