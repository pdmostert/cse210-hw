public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, DateOnly date, TimeOnly time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }


    public override string GenerateFullDescription()
    {
        return $"{base.GenerateStandardDescription()}\nEvent: Outdoor\nWeather: {_weather}";
    }
        public override string GenerateShortDescription()
    {
        return $"Event: Outdoor\nTitle: {base.GetTitle()}\nDate: {base.GetDate()}";
    }


}