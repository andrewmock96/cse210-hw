using System.Collections.Generic;

public interface Commentable
{
    void AddComment(Comment comment);
    int GetCommentCount();
    List<Comment> GetComments();
}