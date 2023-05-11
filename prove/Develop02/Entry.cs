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
        get => _date;
    }
    public string Prompt
    {
        get => _prompt;
    }
    public string Response
    {
        get => _response;
    }

/// <summary>
/// The Display function returns a formatted string containing the date, prompt, and response.
/// </summary>
/// <returns>
/// A string that displays the date, prompt, and response in a formatted way.
/// </returns>
    public string Display()
    {
        return $"Date: {_date} - Prompt:  {_prompt} \n{_response}";
    }

}