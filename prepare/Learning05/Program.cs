using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square new_square = new Square(10,"blue");


        Console.Write($"Area:{new_square.GetArea()}, color:{new_square.GetColor()}");
    }
}