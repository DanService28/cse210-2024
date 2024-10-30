using System;
using Microsoft.Win32.SafeHandles;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager(int score)
    {
        _score = score;
    }

    public void Start()
    {   
        int choise = 0;

        while(choise != 6)
        {
            Console.Clear();
            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choise from the menu: ");
            choise = int.Parse(Console.ReadLine());

            if (choise == 1)
            {
                Console.Clear();
                CreateGoal();
            }

            if (choise == 2)
            {
                Console.Clear();
                ListGoalNames();
                string output = Console.ReadLine();
            }

            if (choise == 3)
            {
                Console.Clear();
                Console.Write("What is the filename for the goal file? ");
                string file = Console.ReadLine();
                SaveGoals(file);
                Console.WriteLine("Goals saved successfully.");
            }

            if (choise == 4)
            {
                Console.Clear();
                Console.Write("What is the filename for the goal file? ");
                string file = Console.ReadLine();
                LoadGoals(file);
            }

            if (choise == 5)
            {
                Console.Clear();
                RecordEvent();
                string output = Console.ReadLine();
            }
        }
        
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You now have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        foreach(var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }
    
    public void ListGoalDetails()
    {
        Console.WriteLine(_score);
        foreach(var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal \n2. Eternal Goal \n3. CheckList Goal \n4. Return");
        Console.Write("What kind of goal would you like to create: ");
        int typeGoal = int.Parse(Console.ReadLine());

        if (typeGoal == 1)
        {
            Console.Write("What is the name of your goal: ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it: ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal: ");
            int points = int.Parse(Console.ReadLine());

            _goals.Add(new SimpleGoal(name, description, points));
        }

        if (typeGoal == 2)
        {
            Console.Write("What is the name of your goal: ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it: ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal: ");
            int points = int.Parse(Console.ReadLine());

            _goals.Add(new EternalGoal(name, description, points));
        }

        if (typeGoal == 3)
        {
            Console.Write("What is the name of your goal: ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it: ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal: ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ListGoal(name, description, points, bonus, target));
        }
        if (typeGoal == 4)
        {
            Start();
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you acomplish?: ");
        if (int.TryParse(Console.ReadLine(), out int goalNumber) && goalNumber > 0 && goalNumber <= _goals.Count)
        {
        var goal = _goals[goalNumber - 1];

        if (!goal.IsComplete())
        {
            _score += goal._points; 
        }

        goal.RecordEvent(); 
        }
        Console.WriteLine($"You have {_score} points.");
    }

    public void SaveGoals(string filename)
    {
        string file = filename;
        using (StreamWriter outputFile = new StreamWriter(file))
        {   
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetDetailsString());
            }
        }
    }

    public void LoadGoals(string filename)
    {

        string filePath = filename;
    

        using (StreamReader reader = new StreamReader(filePath))
        {

        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            string[] parts = line.Split(','); 

            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(name, description, points));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                case "ChecklistGoal":
                    int targetCount = int.Parse(parts[4]);
                    int currentCount = int.Parse(parts[5]);
                    int bonusPoints = int.Parse(parts[6]);
                    var checklistGoal = new ListGoal(name, description, points, targetCount, bonusPoints);
                    checklistGoal.SetCurrentCount(currentCount);
                    _goals.Add(checklistGoal);
                    break;
                default:
                    Console.WriteLine($"Unknown goal type: {type}");
                    break;
            }
        }
        }
    }
}
