using System;

public class ListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ListGoal(string name, string description, int points, int bonus, int target) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;

    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted ++;
            if(_amountCompleted == _target)
            {
                Console.WriteLine($"Congratuliations! You have earned {_points + _bonus} points!");
            }
            else
            {
                Console.WriteLine($"Congratuliations! You have earned {_points} points!");
            }
        }
        else
        {
            Console.WriteLine($"This goal is already completed.");
        }
    }

    public override bool IsComplete()
    {
        return  _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return IsComplete() ? "[X] " + _shortName + " (" + _description + ")" + $" -- Currently completed: " + _amountCompleted + "/" + _target : "[] " + _shortName + " (" + _description+ ")" + $" -- Currently completed: " + _amountCompleted + "/" + _target;
    }

    public override string GetDetailsString()
    {
    return $"ChecklistGoal,{base.GetDetailsString()},{_target},{_amountCompleted},{_bonus}";
    }   

    public void SetCurrentCount(int count)
    {
        _amountCompleted = count;
    }
}