using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction noParam = new Fraction();
            noParam.getFrac();
            noParam.getDec();
        Fraction topOnly = new Fraction(5);
            topOnly.getFrac();
            topOnly.getDec();
        Fraction threeFourths = new Fraction(4,3);
            threeFourths.getFrac();
            threeFourths.getDec();
        Fraction oneThird = new Fraction(3,1); 
            oneThird.getFrac();
            oneThird.getDec();


            



    }
}