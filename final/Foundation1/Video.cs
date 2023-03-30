using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int CommentCount()
    {
        int count = _comments.Count;

        return count;
    }

    public void Display()
    { 
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (seconds): {_length}");
        Console.WriteLine($"Number of Comments: {CommentCount()}\n");
        Console.WriteLine($"Comments:");

        foreach (Comment comment in _comments)
        {
            comment.CommentDisplay();
        }
    }
}