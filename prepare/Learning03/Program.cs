using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction emptyFrac = new Fraction();
        Fraction wholeNum = new Fraction(5);
        Fraction nFraction = new Fraction(6, 7);

        Console.WriteLine(emptyFrac.GetFractionString());
        Console.WriteLine(emptyFrac.GetDecimalValue());

        Console.WriteLine(wholeNum.GetFractionString());
        Console.WriteLine(wholeNum.GetDecimalValue());

        Console.WriteLine(nFraction.GetFractionString());
        Console.WriteLine(nFraction.GetDecimalValue());
    }
}