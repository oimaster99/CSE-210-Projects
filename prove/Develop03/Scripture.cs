public class Scripture {

    private List<Word> _scripture;
    private Reference _ref;

    public Scripture() {
        _scripture = new List<Word>();
        _ref = new Reference("Proverbs", "3", "5", "6", @"Trust in the Lord with 
all thine heart and lean not unto thine own understanding; 
in all ways acknowledge him, and he shall direct thy paths.");

        string content = _ref.GetContents();

        string[] wordSort = content.Split(" ");

        foreach (string word in wordSort) {
            _scripture.Add(new Word(word));
        }

    }

    public Scripture(Reference _ref) {
        this._scripture = new List<Word>();
        this._ref = _ref;

        string content = _ref.GetContents();

        string[] wordSort = content.Split(" ");

        foreach (string word in wordSort) {
            _scripture.Add(new Word(word));
        }

    }

    public void ShowScripture() {
        _ref.DisplayReference();
        string hiddenText;

        foreach (Word word in _scripture) {
            if(word.GetHide()) {
                hiddenText = new string('_', word.GetWord().Length);
                Console.Write($"{hiddenText} ");
            }
            else {
                Console.Write(word.GetWord() + " ");
            }
        }
    }

    public bool HideWords() {
        List<Word> shownWords = AvailWords();

        if (shownWords.Count() == 0) {
            return false;
        }
        else {
            Random rng = new Random();
            int randNum1 = rng.Next(shownWords.Count - 1);
            int randNum2 = rng.Next(shownWords.Count - 1);

            if (randNum2 == randNum1 && randNum2 > 0) {
                randNum2--;
            }
            else if (randNum2 == randNum1 && randNum2 == 0) {
                randNum2++;
            }
            

            shownWords[randNum1].HideWord();
            shownWords[randNum2].HideWord();
            return true;
        }
    }

    public List<Word> AvailWords() {
        List<Word> shownWords = new List<Word>();
        foreach (Word w in _scripture) {
            if (!w.GetHide()) {
                shownWords.Add(w);
            }
        }
        return shownWords;
    }

    /*public string RemoveWord() {
        string[] words = _verse.Split(' ');
    }*/
}