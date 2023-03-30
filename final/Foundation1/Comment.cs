
using System;

public class Comment
{
    private string _personName;
    private string _comment;

    public Comment(string personName, string comment)
    {
        _personName = personName;
        _comment = comment;
    }

    public void CommentDisplay()
    {
        Console.WriteLine($"{_personName}");
        Console.WriteLine($"{_comment}\n");
    }
}