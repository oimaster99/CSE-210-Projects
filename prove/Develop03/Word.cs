public class Word {

    private string _word;
    private bool _hide;
    //private string[] _words;

    public Word(string w) {
        this._word = w;
        this._hide = false;
    }

    public string GetWord() {
        return _word;
    }

    public void HideWord() {
        _hide = true;
    }

    public void DisplayWord() {
        Console.WriteLine(_word);
    }

    public bool GetHide() {
        return _hide;
    }

}