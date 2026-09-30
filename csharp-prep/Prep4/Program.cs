using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>(); 
        Console.WriteLine("Enter a list of numbers type 0 when finished: ");

         int New_number = int.Parse(Console.ReadLine());
        while (New_number != 0)     
        {
           Console.WriteLine("Enter a number: ");
           New_number = int.Parse(Console.ReadLine());
        
         numbers.Add(New_number);
        } 
        }

    }
