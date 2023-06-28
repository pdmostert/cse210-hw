public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    public Video(string title, string author, int length)
    {
        _comments = new();
        _title = title;
        _author = author;
        _length = length;
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public List<Comment> GetListOfComments()
    {
        return _comments;
    }

    public string DisplayVideoInfo()
    {
        return $"Title: {_title} Author: {_author} Length: {_length} seconds";
    }


}