using System;
using System.Collections.Generic;

public class Video
{
    private string title;
    private string author;
    private int lengthInSeconds;
    private List<Comment> comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        this.title = title;
        this.author = author;
        this.lengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();
    }


    public string Title
    {
        get { return title; }
    }

    public string Author
    {
        get { return author; }
    }

    public int LengthInSeconds
    {
        get { return lengthInSeconds; }
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // Method to return the number of comments
    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    // Method to display video details
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {title}, Author: {author}, Length: {lengthInSeconds} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");

        foreach (var comment in comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }
}