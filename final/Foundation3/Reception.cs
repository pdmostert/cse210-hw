public class Reception : Event
{
    private string _emailAddress;

    public Reception(string title, string description, DateOnly date, TimeOnly time, Address address, string emailAddress) : base(title, description, date, time, address)
    {
        _emailAddress = emailAddress;
    }


    public override string GenerateFullDescription()
    {
        return $"{base.GenerateStandardDescription()}\nEvent: Reception\nRSVP: {_emailAddress}";
    }
        public override string GenerateShortDescription()
    {
        return $"Event: Reception\nTitle: {base.GetTitle()}\nDate: {base.GetDate()}";
    }


}