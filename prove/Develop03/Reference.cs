public class Reference {

    private string _book;

    private string _chapter;
    private string _verse;
    private string _verse2 = null;
    private string _contents = null;

    public Reference(string b, string c, string v) {
        this._book = b;
        this._chapter = c;
        this._verse = v;
    }

    public Reference(string b, string c, string v, string v2) {
        this._book = b;
        this._chapter = c;
        this._verse = v;
        this._verse2 = v2;
    }

    public Reference(string b, string c, string v, string v2, string cn) {
        this._book = b;
        this._chapter = c;
        this._verse = v;
        this._verse2 = v2;
        this._contents = cn;
    }

    public string GetBook() {
        return _book;
    }

    public void SetBook(string b) {
        this._book = b;
    }

    public string GetChapter() {
        return _chapter;
    }

    public void SetChapter(string c) {
        this._chapter = c;
    }

    public string GetVerse() {
        return _verse;
    }

    public string GetVerse2() {
        return _verse2;
    }

    public void SetVerse(string v) {
        this._verse = v;
    }

    public void SetVerses(string v, string v2) {
        this._verse = v;
        this._verse2 = v2;
    }

    public string GetContents() {
        return _contents;
    }

    public void SetContents(string cn) {
        this._contents = cn;
    }

    public void DisplayReference() {
        if (_verse2 != null) {
            Console.WriteLine($"{_book} {_chapter}:{_verse}-{_verse2} ");
        }
        else {
            Console.WriteLine($"{_book} {_chapter}:{_verse} ");
        }
    }

}