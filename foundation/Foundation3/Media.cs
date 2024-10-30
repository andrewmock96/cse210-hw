using System;

public abstract class Media
{

    protected string _title;
    protected string _author;
    protected int _lengthInSeconds;


    public string Title => _title;
    public string Author => _author;
    public int LengthInSeconds => _lengthInSeconds;

    protected Media(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }


    public abstract void DisplayInfo();
}