using System;
using System.ComponentModel.DataAnnotations;

public class Video
{
    private string _videoTitle;
    private string _videoAuthor;
    private double _videoLength;
    private List<Comments> _comments = new List<Comments>();

    public Video(string title, string author, double length)
    {
        _videoTitle = title;
        _videoAuthor = author;
        _videoLength = length;
    }

    public void AddComment(params Comments[] comments)
    {
        foreach (var comment in comments)
        {
            _comments.Add(comment);
        }
        
    }

    public int GetVideoCounter()
    {
       return _comments.Count;
    }

    public void DisplayVideoRecords()
    {
        Console.WriteLine($"-{_videoTitle}, {_videoLength} seconds \nFrom: {_videoAuthor}.");
        Console.WriteLine($"Number of comments: {GetVideoCounter()}");

        foreach(var comment in _comments)
        {
            comment.DisplayComment();
        }

        Console.WriteLine();
    }

}