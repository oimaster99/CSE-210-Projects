using System.Net;

class Listing : Activity{

    private List<string> _prompts;
    private List<string> _userAnswers;

    public Listing() {
        this._prompts = new List<string>() {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        this._userAnswers = new List<string>();
    }

    public void GetRndPrompt() {
        Random rng = new Random();

        int rndPrompt = rng.Next(_prompts.Count - 1);

        Console.WriteLine($"--- {_prompts[rndPrompt]} ---");
    }

    public void GetInput(int time) {
        DateTime start = DateTime.Now;
        DateTime fin = start.AddSeconds(time);

        while(DateTime.Now < fin) {
            Console.Write("> ");
            _userAnswers.Add(Console.ReadLine());   
        }
        
    }

    public void ListingAct() {
        Console.Clear();
        Console.WriteLine("Welcome to the Listing Activity.\n");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        int seconds = SetDuration();
        Console.Clear();

        Console.WriteLine("Get ready...");
        animation(5);
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        GetRndPrompt();

        Console.Write("You may begin in: ");
        Countdown(5);
        Console.WriteLine("\n");
        GetInput(seconds);

        Console.WriteLine($"You listed {_userAnswers.Count} items!\n");

        Console.WriteLine("Well done!!");
        animation(5);
        Console.WriteLine($"You have completed another {seconds} seconds of the Listing Activity.");
        animation(5);
    }

}