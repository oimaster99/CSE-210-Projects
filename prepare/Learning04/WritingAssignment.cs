class WritingAssignment : Assignment {

    private string _title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic) {
        this.name = name;
        this.topic = topic;
        this._title = title;
    }

    public void DisplayWritingInformation() {
        //Console.WriteLine($"{name} - {topic}");
        Console.WriteLine(_title);
    }
}