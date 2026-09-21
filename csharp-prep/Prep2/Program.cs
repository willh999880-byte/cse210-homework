using System;

class Program
{
    static void Main(string[] args)
    {

        string input = Console.ReadLine();
        int percentage = int.Parse(input);
        string letter = "A" ;


        if (percentage >= 90)
        {
           letter = "A";
        } 
        else if (percentage >= 80) 
        {
           letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = ("D");
        }
        else
        {
            letter = "F";

        }
        if (percentage >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You failed the class better luck next time.");
        }
        Console.WriteLine($"Your grade is: {letter}");

    }
}