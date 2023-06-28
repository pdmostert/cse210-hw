public class ReceptionEvent : Event
{
    private string _emailAddress;

    public ReceptionEvent(string title, string description, DateOnly date, TimeOnly time, Address address, string emailAddress) : base(title, description, date, time, address)
    {
        _emailAddress = emailAddress;
    }


    public override string GenerateFullDescription()
    {
        throw new NotImplementedException();
    }


}