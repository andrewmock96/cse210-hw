using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learn C# in 10 Minutes", "John Doe", 603);
        Video video2 = new Video("Minecraft Starter Base in 5 Minutes", "Jane Smith", 301);
        Video video3 = new Video("Why Playing Gollum Was My Favorite Roll", "Andy Serkis", 1094);

        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very informative."));
        video1.AddComment(new Comment("Charlie", "I learned a lot, thanks!"));

        video2.AddComment(new Comment("Daisy", "Great Base Design."));
        video2.AddComment(new Comment("Andy", "This isn't even close to a solid base."));
        video2.AddComment(new Comment("Frank", "Make more videos like this?"));

        video3.AddComment(new Comment("Frodo", "Wow. I'm glad you liked your experence."));
        video3.AddComment(new Comment("Sam", "You played the character outstandingly!"));
        video3.AddComment(new Comment("Bilbo", "Sorry for taking your ring... water under the bridge right?"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.DisplayVideo();
        }
    }
}