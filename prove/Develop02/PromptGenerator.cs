using System;

public class PromptGenerator

{
    public List<string> _prompts;
    
    public PromptGenerator()
    {   
        //Create the prompts list. 
        string prompts = "What was the best thing that happened to you today? | Is there anything you wish you had done differently today? |" +
        "What made today special or different from other days? | Did you have any meaningful conversations today? With whom?" +
        "| What do you hope to accomplish tomorrow? | Did you have any creative ideas or thoughts today?";
        _prompts = new List<string>(prompts.Split('|'));
    }


    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(0, _prompts.Count); 
        return _prompts[index];                
    }
}