public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    //Check if word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    //Display word hidden or visible
    public string Display()
    {
        return _isHidden ? "_____": _text;
    }
}