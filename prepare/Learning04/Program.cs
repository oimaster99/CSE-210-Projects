using System;

class Program
{
    static void Main(string[] args)
    {

        string name = "Roberto Rodriguez";

        MathAssignment math1 = new MathAssignment(name, "Fractions", "7.3", "8-19");
        WritingAssignment history1 = new WritingAssignment(name, "European History", "The Causes of World War II by Mary Waters");

        Console.WriteLine("---------------------------------");
        math1.GetSummary();
        math1.DisplayHomeworkList();
        Console.WriteLine("---------------------------------");
        history1.GetSummary();
        history1.DisplayWritingInformation();
        Console.WriteLine("---------------------------------");
    }
}