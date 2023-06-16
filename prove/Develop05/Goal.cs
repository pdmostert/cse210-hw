using System.Text.Json.Serialization;

//https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/polymorphism?pivots=dotnet-7-0
// This article teaches how to action polymorphic Json serialization and deserialization.

[JsonDerivedType(typeof(SimpleGoal), typeDiscriminator: "SimpleGoal")]
[JsonDerivedType(typeof(EternalGoal), typeDiscriminator: "EternalGoal")]
[JsonDerivedType(typeof(CheckListGoal), typeDiscriminator: "CheckListGoal")]
[JsonDerivedType(typeof(BadHabbitGoal), typeDiscriminator: "BadHabbitGoal")]
public abstract class Goal
{
    public Goal(string name, string description, int basePoints)
    {
        _name = name;
        _description = description;
        _basePoints = basePoints;
    }


    private string _name;
    private string _description;
    private int _basePoints;


    // Public property required for Json Serialiser
    public string Name { get => _name; }
    public string Description { get => _description; }
    public int BasePoints { get => _basePoints; }

    public abstract int RecordEvent();
    public abstract bool IsComplete(); // Does IsComplete have to be public ?
    public abstract string DisplayGoal();

}
