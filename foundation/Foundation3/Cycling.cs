using System;

public class Cycling : Activity
{
    private int _speed;

    public Cycling(string date, double length, int speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double inHours = _length * 0.01666;
        return _speed * inHours ;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return _length / GetDistance(); 
    }

    public override string GetActivityType()
    {
        return "Cycling";
    }


}