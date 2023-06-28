public abstract class Event
{
    private string _title;
    private string _description;
    private DateOnly _date;
    private TimeOnly _time;
    private Address _address;

    public Event(string title, string description, DateOnly date, TimeOnly time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GenerateStandardDescription()
    {
        return "";
    }

    public string GenerateShortDescription()
    {
        return "";
    }

    public abstract string GenerateFullDescription();


}