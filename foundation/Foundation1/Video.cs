using System;
using System.Collections.Generic;
class Video
{
    public string title;
    public string author;
    public int lengthInSeconds;

    // List to store comments for the video
    private List<Comment> comments = new List<Comment>();

    // Constructor to initialize video
    public Video(string title, string author, int lengthInSeconds)
    {
        this.title = title;
        this.author = author;
        this.lengthInSeconds = lengthInSeconds;
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // Method to return the number of comments on the video
    public int GetCommentCount()
    {
        return comments.Count;
    }

    // Method to return the comments on the video
    public List<Comment> GetComments()
    {
        return comments;
    }
}