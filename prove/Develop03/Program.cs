using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        Scripture scriptr = new Scripture();

        while (!quit) {

            scriptr.ShowScripture();
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: \n");
            string response = Console.ReadLine();

            if (response == "quit") {
                quit = true;
            }
            Console.Clear();
            if (scriptr.HideWords() == false) {
                quit = true;
            }
            //Word testWord = new Word("Attention my fellow Americans. Today is a good day to get ice cream.");
            //testWord.DisplayWord();
        }
    }
}