public class LecturEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LecturEvent(string title, string description, DateOnly date, TimeOnly time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }




    public override string GenerateFullDescription()
    {
        throw new NotImplementedException();
    }



}