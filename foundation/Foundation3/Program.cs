using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Commentable> mediaItems = new List<Commentable>();

        Video video1 = new Video("Fastest Way to Round 100 on Origins BO3 ZC", "ZombieZKING", 301);
        video1.AddComment(new Comment("Ali123", "Thats super helpful!"));
        video1.AddComment(new Comment("Bobby4", "Tank path by chuch is faster."));
        video1.AddComment(new Comment("user32", "Loved it!"));

        Video video2 = new Video("How to level up the fastest on BO6 MP", "CODFORLIFE", 132);
        video2.AddComment(new Comment("David", "Super Useful"));
        video2.AddComment(new Comment("Abby", "Is there a way without double xp tokens?"));
        video2.AddComment(new Comment("Frank", "Make a video that show the best way to play each map."));

        Video video3 = new Video("Why BO6 is going to flop", "GamersReviewd", 478);
        video3.AddComment(new Comment("Grant", "Quit Hating!"));
        video3.AddComment(new Comment("John Doe", "Thats an interesting opinnion, I figured game pass would help with new players."));
        video3.AddComment(new Comment("Ivan", "Hey"));

        mediaItems.Add(video1);
        mediaItems.Add(video2);
        mediaItems.Add(video3);

        // display
        foreach (Commentable mediaItem in mediaItems)
        {
            if (mediaItem is Media item)
            {
                item.DisplayInfo();
            }

            Console.WriteLine("Comments:");
            foreach (var comment in mediaItem.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine();
        }
    }
}