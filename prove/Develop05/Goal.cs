using System.Text.Json.Serialization;


[JsonDerivedType(typeof(SimpleGoal),typeDiscriminator: "SimpleGoal")]
[JsonDerivedType(typeof(EternalGoal),typeDiscriminator: "EternalGoal")]
[JsonDerivedType(typeof(CheckListGoal),typeDiscriminator: "CheckListGoal")]
public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _basePoints;

public string Name { get => _name; }
public string Description { get => _description;  }
public int BasePoints { get => _basePoints;  }


    public Goal()
    {
        _basePoints = 0;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string DisplayGoal();

}
