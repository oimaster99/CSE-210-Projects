using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> userInts = new List<int>();
        int userRaw;
        bool go = true;
        
        Console.Write("Enter a list of numbers, type 0 when finished.");
        
        do {
            
            Console.Write("\nEnter number: ");

            userRaw = int.Parse(Console.ReadLine());

            if (userRaw == 0) {
                go = false;
            }
            else {
                userInts.Add(userRaw);
            }

        } while (go);

        Console.WriteLine("The sum is: " + userInts.Sum());
        Console.WriteLine("The average is: " + userInts.Average());
        Console.WriteLine("The largest number is: " + userInts.Max());

        userInts.Sort();
        Console.WriteLine("The Sorted list is:");

        foreach (int num in userInts) {
            Console.WriteLine(num);
        }

    }
}