
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int basePoints) 
    {
        _name = name;
        _description = description;
        _basePoints = basePoints;
    }

    public override int RecordEvent()
    {
        return 1;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string ShowGoalProgress()
    {
        return "[x]";
    }



}