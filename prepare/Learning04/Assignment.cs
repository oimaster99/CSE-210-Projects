abstract class Assignment {
    protected string name;
    protected string topic;

    public Assignment(string n, string t) {
        this.name = n;
        this.topic = t;
    }

    public void GetSummary() {
        Console.WriteLine($"{name} - {topic} ");
    }

}