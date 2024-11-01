using System;
using System.Runtime.CompilerServices;

public class Running : Activity
{
    private double _distance;

    public Running(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double inHours = _length * 0.01666;
        return _distance / inHours;
    }

    public override double GetPace()
    {
        return _length / _distance; 
    }

    public override string GetActivityType()
    {
        return "Running";
    }

}