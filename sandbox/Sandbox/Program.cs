using System;

class Program
{
    static void Main(string[] args)
    {
       bool done = false;
       while( ! done)
        {
            Console.Write("Are we done yet? y/n ");
            done = Console.ReadLine().ToLower() == "y";
        }
    }
}