using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if(!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have earned {_points}!");   
        }
        else
        {
            Console.WriteLine($"This goal is already completed");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        return $"SimpleGoal,{base.GetDetailsString()},{_isComplete}";
    }

    public override string GetStringRepresentation()
    {
        return IsComplete() ? "[X] " + _shortName + " (" +_description + ")": "[] " + _shortName + " (" +_description +")";
    }
}