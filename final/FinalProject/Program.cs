using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");

        Player player = new Player("Joebama", 100, 100, 35, 5, 10, 1);
        Enemy enemy = new Enemy("Zombie", 100, 100, 5, 10, 5, 1, "cowardly");

        Battle battle = new Battle(player, enemy); 


    }
}