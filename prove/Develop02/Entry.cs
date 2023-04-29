public class Entry
{
    private string _date;
    private string _prompt;
    private string _response;

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }
    public Entry(string prompt, string response)
    {
        _date = DateTime.Now.ToShortDateString();
        _prompt = prompt;
        _response = response;
    }

    public string Date
    {
        get { return _date; }
    }
    public string Prompt
    {
        get { return _prompt; }
    }
    public string Response
    {
        get { return _response; }
    }


    public string Display()
    {
        return $"Date: {_date} - Prompt:  {_prompt} \n{_response}";
    }

}