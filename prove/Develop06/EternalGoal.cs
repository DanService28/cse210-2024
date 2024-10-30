using System;

public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! you have earned {_points} points!");
    }

    public override bool IsComplete()
    {
        return false;
    }
    public override string GetDetailsString()
    {
        return $"EternalGoal,{base.GetDetailsString()}";
    }

    public override string GetStringRepresentation()
    {
        return IsComplete() ? "[X] " + _shortName + " (" +_description + ")": "[] " + _shortName + " (" +_description +")";
    }
}