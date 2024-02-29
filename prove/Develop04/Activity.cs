class Activity {

    private List<string> _anim = new List<string>() {"|", "/", "-", "\\"};
    private int _duration = 12;

    public void animation(int time) {

        DateTime start = DateTime.Now;
        DateTime fin = start.AddSeconds(time);

        while(DateTime.Now < fin) {
            Console.Write(_anim[0]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write(_anim[1]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write(_anim[2]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write(_anim[3]);
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
    }

    public void Countdown(int num) {
        for (int i = num; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int SetDuration() {
        //Had to do this long winded cast cause Console.Read was returning really weird numbers.
        Console.Write("How long, in seconds, would you like for your session?: ");
        string durCast = Console.ReadLine();
        int.TryParse(durCast, out this._duration);
        return _duration;
    }

    public int GetDuration() {
        return _duration;
    }

}