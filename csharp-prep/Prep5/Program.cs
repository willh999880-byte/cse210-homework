using System;

class Program
{
    static void Main(string[] args)
    {


       DisplayWelcome();
       string user_name = PromptUserName();
       int number = PromptUserNumber();
       int BirthYear;
       PromptUserBirthYear(out BirthYear);
       int squared = SquareNumber(number);
       DisplayResult(user_name, squared, BirthYear);

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
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favorite_number = int.Parse(Console.ReadLine());
            return favorite_number;
        }
        static void PromptUserBirthYear(out int BirthYear)
        {
            Console.Write("Please enter the year you were born: ");
            BirthYear = int.Parse(Console.ReadLine());

        }
        static int SquareNumber(int number)
        {
            int squared_number = number * number; 

            return squared_number;
        }
        static void DisplayResult(string user_name, int squared, int BirthYear)
        {
            Console.WriteLine($"{user_name}, the square of your number is {squared}");
            int age_of_user = 2026 - BirthYear;
            Console.WriteLine($"{user_name}, you will turn {age_of_user} this year."); 
        }

     


    }
}