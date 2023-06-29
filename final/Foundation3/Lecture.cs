public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateOnly date, TimeOnly time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }


    public override string GenerateFullDescription()
    {
        return $"{base.GenerateStandardDescription()}\nEvent: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    public override string GenerateShortDescription()
    {
        return $"Event: Lecture\nTitle: {base.GetTitle()}\nDate: {base.GetDate()}";
    }


}