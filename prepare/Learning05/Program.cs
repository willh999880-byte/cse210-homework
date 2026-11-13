using System;
using System.ComponentModel;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square new_square = new Square(10,"blue");
        Circle new_circle = new Circle(3.14,"green");
        Rectangle new_rectangle = new Rectangle(5,10,"red");
        
        List<Shape> all_shapes =new List<Shape>();
        
            all_shapes.Add(new_square);
            all_shapes.Add(new_circle);
            all_shapes.Add(new_rectangle);

 
            foreach(Shape s in all_shapes)
        {
            Console.WriteLine($"Area:{s.GetArea()}, color:{s.GetColor()}");
        }
       
    }
}