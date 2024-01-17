using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        //int count = 5;
        Random random = new Random();
        int magicNum = random.Next(0, 100);
        int guess;
        int guesscount = 0;
        bool go = true;

        do 
        {
            Console.Write("What is your guess?: ");
            guess = int.Parse(Console.ReadLine());
            guesscount++;

            if (guess > magicNum) {
                Console.WriteLine("Higher");
            }
            else if (guess < magicNum) {
                Console.WriteLine("Lower");
            }
            else if (guess == magicNum) {
                Console.WriteLine("You Guessed it!");
                magicNum = random.Next(0, 100);
            }
            else {
                Console.WriteLine("Error! This wasn't supposed to happen!");
            }
            
            Console.WriteLine("Current guess count: " + guesscount);
            
            Console.Write("Continue? (yes/no): ");
            String prompt = Console.ReadLine();

            go = String.Equals(prompt, "yes", StringComparison.CurrentCultureIgnoreCase);
        } 
        while (go);
    }
}