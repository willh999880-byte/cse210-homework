using System;

class Program
{
    static void Main(string[] args)
    {
        
     int user_guess_counter = 0;
     int real_magic_number = new Random().Next(1, 101);
     Console.WriteLine("What is your guess? ");
     int user_guess = int.Parse(Console.ReadLine());
    while (real_magic_number != user_guess)
    {
       Console.WriteLine("What is your guess? ");
       if (user_guess_counter > 0)
            {
               user_guess = int.Parse(Console.ReadLine()); 
            } 
       

         if (real_magic_number == user_guess) 
        {
         
          Console.WriteLine($"You guessed it in {user_guess_counter}");      
        }
     else if (real_magic_number > user_guess)
        {   
            user_guess_counter = user_guess_counter += 1;
            Console.WriteLine("Higher");
        }
     else if (real_magic_number < user_guess)
        {
            user_guess_counter = user_guess_counter += 1;
            Console.WriteLine("Lower");
        }
     else
        {
            Console.WriteLine("Unknown input. Please try again");
        }   
    }}
}