using System;

class Program
{
    static void Main(string[] args)
    {
       bool done;
       do
        {
         Console.Write("Are we done yet? Y/N ");
         done = Console.ReadLine().ToLower() == "y";


        }while(!done);

    }
}