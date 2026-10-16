using System.Dynamic;
using System.IO.Pipes;
using System;
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
        SetBottom(bottom);
    }
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
         _top = top;
        
        
        
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        
            if (bottom > 0)
            {
               _bottom = bottom;
                
            }
            else
            {
                _bottom = 1;
                
            }
        
    }

    public string GetFractionString()
    { 
        string new_fraction = $"{_top}/{_bottom}";
        return new_fraction;
    }

    public double GetDecimalValue()
    {
        double decimal_answer = (double)_top/(double)_bottom;
        return decimal_answer;
    }
    
    

}