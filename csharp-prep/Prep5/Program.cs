using System;

class Program
{
    static void Main(string[] args)
    {

        void DisplayWelcome() {
            Console.WriteLine("Welcome to the program!");
        }

        String PromptUserName() {
            Console.WriteLine("What is your name?: ");

            String userName = Console.ReadLine();

            return userName;
        }

        int PromptUserNumber() {
            Console.WriteLine("What is your favorite number?: ");

            int userNum = int.Parse(Console.ReadLine());

            return userNum;
        }

        int SquareNumber(int num) {
            return num * num;
        }

        void DisplayResult(String name, int square) {
            Console.WriteLine($"Your user name: {name}");
            Console.WriteLine($"Your squared integer: {square}");
        }

        DisplayWelcome();
        String userName = PromptUserName();
        int userNum = PromptUserNumber();
        int squareNum = SquareNumber(userNum);
        DisplayResult(userName, squareNum);
    }
}