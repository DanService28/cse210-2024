using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, double length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        double inHours = _length * 0.01666;
        return GetDistance() / inHours;
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }
    public override string GetActivityType()
    {
        return "Swimming";
    }


}