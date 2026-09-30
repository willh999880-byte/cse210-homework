using System;

class Program
{
    static void Main(string[] args)
    {
     Console.WriteLine("What is the magic number: ");
     int real_magic_number = int.Parse(Console.ReadLine());
     Console.WriteLine("What is your guess? ");
     int user_guess = int.Parse(Console.ReadLine());

     if (real_magic_number == user_guess) 
     {
      Console.WriteLine("Correct you guessed the magic number!");      
     }
     else if (real_magic_number > user_guess)
        {
            Console.WriteLine("Higher");
        }
     else if (real_magic_number < user_guess)
        {
            Console.WriteLine("Lower");
        }
     else
        {
            Console.WriteLine("Unknown input. Please try again");
        }   
    }
}