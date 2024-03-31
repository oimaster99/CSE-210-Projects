using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Green", 6.5);

        string color = square.GetColor();

        Console.WriteLine(color);

        square.SetColor("Brown");
        color = square.GetColor();
        Console.WriteLine(color);
    }
}