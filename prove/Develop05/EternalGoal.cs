public class EternalGoal : Goal
{
    private int _completeCount;

    public int CompleteCount { get => _completeCount; }

    public EternalGoal(string name, string description, int basePoints, int completeCount):base(name, description, basePoints)
    {
        // _name = name;
        // _description = description;
        // _basePoints = basePoints;
        _completeCount = completeCount;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override int RecordEvent()
    {
        _completeCount++;
        return BasePoints;
    }

    public override string DisplayGoal()
    {
        return $"[ ] {Name} ({Description}) - Completed {_completeCount} times. Points Gained {_completeCount * BasePoints}";
    }
}