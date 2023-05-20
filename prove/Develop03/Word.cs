public class Word
{

    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }
/// <summary>
/// The function sets a boolean variable to true, indicating that something is hidden.
/// </summary>
    public void Hide()
    {
        _isHidden = true;
    }
/// <summary>
/// The Show function sets the _isHidden variable to false.
/// </summary>
    public void Show()
    {
        _isHidden = false;
    }
/// <summary>
/// The function returns either the original word or a string of underscores of the same length if the
/// word is hidden.
/// </summary>
/// <returns>
/// The method `GetRenderedText()` returns a string. If the `_isHidden` field is true, it returns a
/// string with underscores in place of each letter in the `_word` field. If `_isHidden` is false, it
/// returns the `_word` field as is.
/// </returns>
    public string GetRenderedText()
    {
        if (_isHidden)
        {
            string placeHolder = "";
            // hide letters with _
            int count =  _word.Length;
            for (int i = 0; i < count; i++)
            {
                placeHolder += "_";
            }
            return placeHolder;
        }
        else
        {
            return _word;
        }
    }

}