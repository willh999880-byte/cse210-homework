
    class Circle
    {
        private double _radius;

        public Circle()
    {
        _radius = 0.0;
    }
    
    public Circle(double radius) // a constructor has the same name as the class, no return type, and is public.
    {
        Set_Radius(radius);
    }

        public double Getarea()
        {
            return _radius * _radius * 3.14159;
        }

private void Set_Radius(double radius)
    {
        if (radius < 0.0)
        {
            _radius = 1.0;
            Console.WriteLine("Error, must have radius >= 0");
        }
        else
        {
            _radius = radius;
        };
    }
    public double GetRadius()
    {
        return _radius;
    }

    }
 