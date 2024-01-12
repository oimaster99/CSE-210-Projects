using System;

class Program
{
    //Main Method
    static void Main(string[] args)
    {
        //Asks the user for their grade in a percentage number format.
        Console.Write("What is your grade percentage?: ");

        //Converts said input into an integer.
        int grade = Int32.Parse(Console.ReadLine());

        //Initialize the variable for the letter grade.
        String letterGrade;
        
        /*Checks for grade percentage, and sets the letter grade appropriately.
          Also accounts for plus and minuses on grade.*/
        if (grade >= 90) {
            letterGrade = "A";
            if (grade <= 93) {
                letterGrade += "-";
            }
        }
        else if (grade >= 80) {
            letterGrade = "B";
            if (grade >= 87) {
                letterGrade += "+";
            }
            else if (grade <= 83) {

                letterGrade += "-";
            }
        }
        else if (grade >= 70) {
            letterGrade = "C";
            if (grade >=  77) {
                letterGrade += "+";
            }
            else if (grade <= 73) {
                letterGrade += "-";
            }
        }
        else if (grade >= 60) {
            letterGrade = "D";
            if (grade >= 67) {
                letterGrade += "+";
            }
            else if (grade <= 63) {
                letterGrade += "-";
            }
        }
        else {
            letterGrade = "F";
        }

        /*Prints the letter grade to the console, and checks if 
          the grade is a 70 or higher for passing. */
        Console.WriteLine("Your grade is " + letterGrade + ".");

        if (grade >= 70) {
            Console.WriteLine("Congratulations, You Passed!");
        }
        else {
            Console.WriteLine("Sorry, you didn't pass... :(");
        }
    }
}