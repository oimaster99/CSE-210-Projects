using System.Reflection;
using System.Security.AccessControl;

public class Job {
    private string _company;
    private string _jobtitle;
    private int _startYear;
    private int _endYear;

    public Job(string company, string title, int startYear, int endYear) {
        this._company = company;
        this._jobtitle = title;
        this._startYear = startYear;
        this._endYear = endYear;
    }

    public void Display() {
        Console.WriteLine($"Company: {_company}");
        Console.WriteLine($"Title: {_jobtitle}");
        Console.WriteLine($"Year Started: {_startYear}");
        Console.WriteLine($"Year Ended: {_endYear}");
    }
}