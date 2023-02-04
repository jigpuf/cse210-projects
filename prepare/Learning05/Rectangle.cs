using System;


public class Rectangle : Shape
{
    private double _side;
    private double _bottom;
    public Rectangle(string color, double side, double bottom) : base (color){
        _side = side;
        _bottom = bottom;
    }
    public override double GetArea(){
        return _side * _bottom;
    }
}