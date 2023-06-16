public class BadHabbitGoal : Goal
{

    private int _completeCount;
    public int CompleteCount { get => _completeCount; }
    public BadHabbitGoal(string name, string description, int basePoints) : base(name, description, basePoints)
    {
        _completeCount = 0;
    }


    public override string DisplayGoal()
    {
         return $"[ ] {Name} ({Description}) - Completed {_completeCount} times. Points Lost {_completeCount * BasePoints}";
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


}