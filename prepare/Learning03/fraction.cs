using System;

class Fraction
{
    private int _top;
    private int _bottom;
//This constructor builds a fraction of 1/1 with no parameters(setter)
    public Fraction(){
        _bottom=1;
        _top=1;
    }
//This constructor builds a fraction with only the top number as a parameter(setter)
    public Fraction(int topNumber){
        _bottom=1;
        _top=topNumber;
    }
//THis constructor takes 2 parameters to for the fration(setter)
    public Fraction(int bottomNumber, int tNumber){
        _bottom=bottomNumber;
        _top=tNumber;
    }

//THis method gives the fraction form(getter)
public void getFrac(){
    Console.WriteLine($"{_top}/{_bottom}");
}

//This method gives the decimal form(getter)

public void getDec(){
    Console.WriteLine($"{(double)_top/_bottom}");

}

}