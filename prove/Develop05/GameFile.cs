public class GameFile
{
    private int _points;
    private List<Goal> _goals;

    public int Points { get => _points; set => _points = value;}
    public List<Goal> Goals { get => _goals; set => _goals = value; }

    // public GameFile(int points, List<Goal> goals)
    // {
    //     _points = points;
    //     _goals = goals;
    // }
    public GameFile( )
    {
        _points = 0;
        _goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }   



}