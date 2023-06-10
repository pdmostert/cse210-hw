public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _basePoints;

    public Goal()
    {
        _basePoints = 0;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string ShowGoalProgress();

}
