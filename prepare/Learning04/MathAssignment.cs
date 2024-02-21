class MathAssignment : Assignment {

    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string ts, string p) : base(name, topic){
        this.name = name;
        this.topic = topic;
        this._textbookSection = ts;
        this._problems = p;
    }

    public void DisplayHomeworkList() {
        //Console.WriteLine($"{name} - {topic}");
        Console.WriteLine($"Section {_textbookSection} Problems {_problems}");
    }

}