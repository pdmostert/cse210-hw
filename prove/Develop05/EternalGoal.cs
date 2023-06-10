public class EternalGoal : Goal
{
    private int _completeCount;

    public EternalGoal(string name, string description, int basePoints, int completeCount)
    {
        _name = name;
        _description = description;
        _basePoints = basePoints;
        _completeCount = completeCount;
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override int RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override string ShowGoalProgress()
    {
        throw new NotImplementedException();
    }
}