using System;

class Program
{
    static void Main(string[] args)
    {
        string Firstname;
        string Lastname;
        Console.Write("Please enter your first name: ");
        Firstname = Console.ReadLine();
        Console.Write("Please enter your last name: ");
        Lastname = Console.ReadLine();

        Console.WriteLine($"Your name is: {Lastname}, {Firstname} {Lastname}. ");
        
    }
}