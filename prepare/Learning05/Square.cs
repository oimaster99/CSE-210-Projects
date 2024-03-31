using System.Runtime.InteropServices;

class Square : Shape {

    private double _side;

    public Square(string _color, double side) : base(_color) {
        base._color = _color;
        this._side = side;
    }

    public override double GetArea() {
        return _side * _side;
    }

}