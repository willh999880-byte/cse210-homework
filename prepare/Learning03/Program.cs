using System;
using System.Diagnostics;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
       Fraction f1 = new Fraction();
       Console.WriteLine(f1.GetFractionString());
       Console.WriteLine(f1.GetDecimalValue());
       Fraction f2 = new Fraction(5);
       Console.WriteLine(f2.GetFractionString());
       Console.WriteLine(f2.GetDecimalValue());
       Fraction f3 = new Fraction(6,7);
       Console.WriteLine(f3.GetFractionString());
       Console.WriteLine(f3.GetDecimalValue());

       
    
    int number_loop = 0;
    Random random= new Random(); 
    Fraction new_fraction = new Fraction();

    while (number_loop < 20)
        {
            int top = random.Next(1, 100); 
            int bottom = random.Next(1,100);
            new_fraction.SetTop(top);
            new_fraction.SetBottom(bottom);
             

            Console.Write($"Fraction {number_loop + 1}: String :{new_fraction.GetFractionString()}");
            Console.WriteLine($" Number : {new_fraction.GetDecimalValue()}");
            number_loop = number_loop + 1; 
        }
    
    

       
      

       

       

    }
}