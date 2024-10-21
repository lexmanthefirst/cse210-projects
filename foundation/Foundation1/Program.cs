using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create video 1 and add comments
        Video video1 = new Video("Learn C# Basics", "Tech Guru", 3000);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Helpful tutorial."));
        video1.AddComment(new Comment("Charlie", "Thanks for this!"));

        // Create video 2 and add comments
        Video video2 = new Video("C# Advanced Techniques", "Code Expert", 4200);
        video2.AddComment(new Comment("Dave", "Amazing content."));
        video2.AddComment(new Comment("Eve", "I found this very insightful."));
        video2.AddComment(new Comment("Frank", "This was a bit too fast."));

        // Create video 3 and add comments
        Video video3 = new Video("Data Structures in C#", "Coder Pro", 3600);
        video3.AddComment(new Comment("Grace", "Very well explained."));
        video3.AddComment(new Comment("Henry", "Just what I needed."));
        video3.AddComment(new Comment("Ivy", "Clear and concise."));

        // Add all videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display video details and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.title}");
            Console.WriteLine($"Author: {video.author}");
            Console.WriteLine($"Length: {video.lengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            // Display all comments for the video
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"\t{comment.commenterName}: {comment.commentText}");
            }
            Console.WriteLine();
        }
    }
}