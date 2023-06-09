
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public bool Complete {get =>_isComplete; set => _isComplete = value;}
    public SimpleGoal(string name, string description, int basePoints):base(name, description,basePoints)
    {

    }


    public override int RecordEvent()
    {
        _isComplete = true;
        return BasePoints;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string DisplayGoal()
    {
        if (_isComplete)
        {
            return $"[X] {Name} ({Description})";
        }
        else
        {
            return $"[ ] {Name} ({Description})";
        }
    }
}