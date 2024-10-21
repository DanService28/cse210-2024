using System;

public class ReflectingActivity : Activity
{
    List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    List<string> _questions = new List<string>()
    {
        "-Why was this experience meaningful to you?",
        "-Have you ever done anything like this before?",
        "-How did you get started?",
        "-How did you feel when it was complete?",
        "-What made this time different than other times when you were not as successful?",
        "-What is your favorite thing about this experience?",
        "-What could you learn from this experience that applies to other situations?",
        "-What did you learn about yourself through this experience?",
        "-How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base ("Reflection Activity", "This activity will help you reflect on times in your life when you" + 
    "have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {    
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        return prompt;
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        string question = _questions[rand.Next(_questions.Count)];
        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"   ---{GetRandomPrompt()}---");
    }

    public void DisplayQuestion()
    {
        Console.Write(GetRandomQuestion());
    }


    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Get Ready.");
        ShowSpinner(5);
        Console.WriteLine();

        Console.WriteLine("Consider the following propmt:\n");
        DisplayPrompt();

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following question as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(8);
            Console.WriteLine();
        }
        
        Console.WriteLine();
        DisplayEndingMessage();
        ShowCountDown(5);
    }
}