using System;

class Program
{
    //Main Method
    static void Main(string[] args)
    {
        //Asks the user for their first and last names, and stores them into strings.
        Console.Write("What is your first name?: ");
        String firstName = Console.ReadLine();

        Console.Write("What is your last name?: ");
        String lastName = Console.ReadLine();

        //Prints the first and last name of user in fashion of a James Bond quote.
        Console.WriteLine("\nYour name is " + lastName + ", " + firstName + " " + lastName + ".");
    }
}