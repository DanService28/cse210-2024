using System;

public class Comments
{
    private string _username;
    private string _text;

    public Comments(string name, string text)
    {
        _username = name;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"& {_username}: {_text}");
    }
}