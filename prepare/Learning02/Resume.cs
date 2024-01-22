using System.ComponentModel.DataAnnotations;

public class Resume {

    private string _name;
    public List<Job> _jobs;

    public Resume(string name) {
        this._name = name;
        this._jobs = new List<Job>();
    }

    public Resume() {
        this._jobs = new List<Job>();
    }

    public void Display() {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("\nCurrent Jobs \n");
        foreach (Job job in _jobs) {
            job.Display();
            Console.WriteLine("-----------------------------");
        }
    }

}