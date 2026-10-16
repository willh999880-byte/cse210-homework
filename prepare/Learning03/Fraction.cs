using System.Dynamic;
using System.IO.Pipes;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholenumber)
    {
        _top = wholenumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {  
        _top = top;
        _bottom = bottom;
    }
    public int GetTop()
    {
        return _top;
    }

    public int SetTop(int top)
    {
         _top = top;
        
        
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public int SetBottom(int bottom)
    {
        
            if (bottom > 0)
            {
               _bottom = bottom;
               return _bottom;
            }
            else
            {
                _bottom = 1;
                return _bottom;
            }
        
    }
    
    

}