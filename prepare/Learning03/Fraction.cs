public class Fraction {

    private int _top;
    private int _bottom;

    public Fraction() {
        this._top = 1;
        this._bottom = 1;
    }

    public Fraction(int wholeNumber) {
        this._top = wholeNumber;
        this._bottom = 1;
    }

    public Fraction(int top, int bottom) {
        this._top = top;
        this._bottom = bottom;
    }

    public int GetTop() {
        return _top;
    }

    public void SetTop(int top) {
        this._top = top;
    }

    public int GetBottom() {
        return _bottom;
    }

    public void SetBottom(int bottom) {
        this._bottom = bottom;
    }

    public string GetFractionString() {
        string fracString = $"{_top}/{_bottom}";
        return fracString;
    }

    public double GetDecimalValue() {
        double decVal = Convert.ToDouble(_top) / Convert.ToDouble(_bottom);
        return decVal;
    }

}