using System;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int total = 0;
        int biggest_number = 0;
        List<int> numbers = new List<int>(); 
        Console.WriteLine("Enter a list of numbers type 0 when finished: ");

         int New_number = int.Parse(Console.ReadLine());
         numbers.Add(New_number);
         
        while (New_number != 0)     
        {
           Console.WriteLine("Enter a number: ");
           New_number = int.Parse(Console.ReadLine());
           if (New_number > biggest_number) 
            {
                biggest_number = New_number;
            }
          if (New_number != 0)
          {
           numbers.Add(New_number);
          }
        }
        foreach (int number in numbers)
        {
            
             total = number + total ;
        } 
         int total_numbers_in_list = numbers.Count;
         float average_of_list = (total/total_numbers_in_list);
        Console.WriteLine($"Sum: {total}");
        Console.WriteLine($"Average: {average_of_list}");
        Console.WriteLine($"The largest number is: {biggest_number}");
        }

    }
