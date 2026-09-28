using System;
using System.Reflection.Metadata;

class Program
{

    
    static void Main(string[] args)
    {
    
       List <string> myfriends = ["Bob", "Betty", "Bubba"]; 
       myfriends.Add("James");
       myfriends.Add("Doug");

       foreach(string name in myfriends)
        {
            Console.WriteLine(name);
        }

        static double Addnumbers(double x, int y)
        
        {
            return x+y;
        }
       
        
        Displaygreeting("Bob");

        double answer= Addnumbers(12.234, 10);
        Console.WriteLine(answer);
    
    }
}