class Shape {

    protected string _color;

    public Shape(string c) {
        this._color = c;
    }

    public string GetColor() {
        return _color;
    }

    public void SetColor(string c) {
        this._color = c;
    }

    public virtual double GetArea() {
        return 0;
    }

}