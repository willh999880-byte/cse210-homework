using System.Formats.Asn1;

public class Square : Shape
{
    double _side;


    public Square(double side, string color) : base(color)
    {
        _side = side;
    }


    public override double GetArea()
    {
        double square_area = _side * _side;
        return square_area;
    }
}