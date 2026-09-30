using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");

        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string user_name = Console.ReadLine();
            
            return user_name;

        }
     DisplayWelcome();
     PromptUserName();

    }
}