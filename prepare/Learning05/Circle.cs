public class Circle : Shape
{
    double _radius;


    public Circle(double radius, string color): base(color)
    {
        _radius = radius;
        
    }

    public override  double GetArea()
    {
        
        double circle_area = Math.PI * _radius * _radius;
        return circle_area;
    }
}