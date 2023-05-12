public class Word
{

    private string _word;
    private bool _isHiden;

    public Word(string word)
    {
        _word = word;
        _isHiden = false;
    }


    public void Hide()
    {
        _isHiden = true;
    }

    public void Show()
    {
        _isHiden = false;
    }

    public string GetRenderedText()
    {
        if (_isHiden)
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