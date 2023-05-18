public class Word
{

    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }


    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

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