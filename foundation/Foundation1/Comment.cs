using System;

public class Comment
{
    private string commenterName;
    private string commentText;

    public Comment(string name, string text)
    {
        commenterName = name;
        commentText = text;
    }

    public string CommenterName
    {
        get { return commenterName; }
    }

    public string CommentText
    {
        get { return commentText; }
    }

    // Method to display the comment
    public void DisplayComment()
    {
        Console.WriteLine($"  {commenterName}: {commentText}");
    }
}