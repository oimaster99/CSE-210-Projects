using System.Diagnostics;

class Breathing {

    private int _breathIn = 2;
    private int _breathOut = 3;
    private int _breathInInc = 2;
    private int _breathOutInc = 3;
    private Activity _anim = new Activity();

    public void BreathAct() {
        Console.Clear();
        Console.WriteLine("Welcome to the Breathing Activity.\n");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing");
        Console.Write("\nHow long, in seconds, would you like for your session?: ");

        int seconds = _anim.SetDuration();
        Console.Clear();

        Console.WriteLine("Get Ready...");
        _anim.animation(5);
        Console.WriteLine("\n");
        BreathTime(seconds);

        Console.WriteLine("\nWell done!!");
        _anim.animation(5);

        Console.WriteLine($"You have completed another {seconds} seconds of the Breathing Activity.");
        _anim.animation(5);
    }

    private void BreathTime(int time) {
        int IncAmount = 0;
        int newBreathIn = _breathIn;
        int newBreathOut = _breathOut;

        DateTime start = DateTime.Now;
        DateTime fin = start.AddSeconds(time);

        while (DateTime.Now < fin) {
            int breathInVisual = newBreathIn;
            int breathOutVisual = newBreathOut;

            Console.Write("Breathe in...");
            for (int i = newBreathIn; i > 0; i--) {
                Console.Write(breathInVisual);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                breathInVisual--;
            }

            Console.Write("\nNow breathe out...");
            for (int i = newBreathOut; i > 0; i--) {
                Console.Write(breathOutVisual);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                breathOutVisual--;
            }

            if (IncAmount == 0) {
                newBreathIn += _breathInInc;
                newBreathOut += _breathOutInc;
                IncAmount++;
            }
            Console.WriteLine("\n");

        }
    }

}