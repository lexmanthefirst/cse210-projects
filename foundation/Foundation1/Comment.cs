using System;
using System.Collections.Generic;

// Class to represent a Comment on a video
class Comment
{
    public string commenterName;
    public string commentText;

    // Constructor to initialize comment
    public Comment(string commenterName, string commentText)
    {
        this.commenterName = commenterName;
        this.commentText = commentText;
    }
}
