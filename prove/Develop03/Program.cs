using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Quic;

class Program
{
    
    static void Main(string[] args)
    {
        

        Scripture myscripture = new  Scripture("Moses", 1, [39], "Behold, this is my work and my glory to bring to pass the immortality and eternal life of man");
        Console.Clear();
        string user_input = " ";
        
        while (user_input != "quit")
        {
             Console.Clear();
            myscripture.ShowScripture();
            Console.WriteLine();
            Console.Write("Hit enter to hide three words or 'quit' to exit the program.");
            user_input = Console.ReadLine();
            if (user_input != "quit")
            {
                
                myscripture.Remove_Three_Words();
            }
        }
        Console.WriteLine("Thank you for memorizing today!");

        
    }
}