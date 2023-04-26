public class Entry
{

    public string Date { get; set; } = DateTime.Now.ToShortDateString();
    public string Prompt { get; set; }
    public string Response { get; set; }

    public string Display()
    {
        return $"Date: {Date} - Prompt:  {Prompt} \n{Response}";
    }

}