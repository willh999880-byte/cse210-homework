using System.Drawing;

public class Rectangle : Shape
{
    double _length;
    double _side;


    public Rectangle(double length, double side, string color): base(color)
    {
        _length = length;
        _side = side;
    }

    public override double GetArea()
    {
        double area_rectangle = _length * _side;
        return area_rectangle;
    }
}
