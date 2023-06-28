public class OutdoorEvent : Event
{
    private string _weather;

    public OutdoorEvent(string title, string description, DateOnly date, TimeOnly time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }


    public override string GenerateFullDescription()
    {
        throw new NotImplementedException();
    }


}