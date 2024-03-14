using System;
using System.Data.Common;

public class Rationaldigit
{
    private int numerator;
    public int Numerator
    {
        get { return numerator; }
        private set { numerator = value; }
    }

    private int denominator;
    public int Denominator
    {
        get { return denominator; }
        private set { denominator = value; }
    }

    public Rationaldigit(int a, int b)
    {
        Numerator = a;

        if (b==0)
        {
            throw new ArgumentException("b can't be equal 0");
        }
        else Denominator = b;
    }

    override public string ToString()
    {
        Reduction();
        string astring = Numerator.ToString();
        string bstring = Denominator.ToString();
        if(Numerator == 0)
        {
            return "0";
        }
        else if(Denominator == 1)
        {
            return $"{astring}";
        }
        else
        {
            return $"{astring}/{bstring}";
        }
    }

    public static Rationaldigit operator +(Rationaldigit a, Rationaldigit b)
    {
        
            Rationaldigit c = new(0, 1);
            if (a.Denominator == b.Denominator)
            {
                c.Numerator = a.Numerator + b.Numerator;
                c.Denominator = a.Denominator;
            }
            else if (a.Denominator > b.Denominator)
            {
                if (a.Denominator % b.Denominator == 0)
                {
                    c.Numerator = a.Numerator + (b.Numerator * (a.Denominator / b.Denominator));
                    c.Denominator = a.Denominator;
                }
                else
                {
                    c.Denominator = a.Denominator * b.Denominator;
                    c.Numerator = (a.Numerator * (c.Denominator / a.Denominator)) + (b.Numerator * (c.Denominator / b.Denominator));
                }
            }
            else
            {
                if (b.Denominator % a.Denominator == 0)
                {
                    c.Numerator = b.Numerator + (a.Numerator * (b.Denominator / a.Denominator));
                    c.Denominator = b.Denominator;
                }
                else
                {
                    c.Denominator = a.Denominator * b.Denominator;
                    c.Numerator = (a.Numerator * (c.Denominator / a.Denominator)) + (b.Numerator * (c.Denominator / b.Denominator));
                }
            }
            return c;
        }


    public static Rationaldigit operator -(Rationaldigit a, Rationaldigit b)
    {
            Rationaldigit c = new(0, 1);
            if (a.Denominator == b.Denominator)
            {
                c.Numerator = a.Numerator - b.Numerator;
                c.Denominator = a.Denominator;
            }
            else
            {
                c.Denominator = a.Denominator * b.Denominator;
                c.Numerator = a.Numerator * (c.Denominator / a.Denominator) - b.Numerator * (c.Denominator / b.Denominator);
            }
            return c;
    }

    public static Rationaldigit operator *(Rationaldigit a, Rationaldigit b)
    {
            Rationaldigit c = new(0, 1);
            c.Numerator = a.Numerator * b.Numerator;
            c.Denominator = a.Denominator * b.Denominator;
            return c;
    }

    public static Rationaldigit operator /(Rationaldigit a, Rationaldigit b)
    {
            Rationaldigit c = new(0, 1);
            c.Numerator = a.Numerator * b.Denominator;
            c.Denominator = a.Denominator * b.Numerator;
            return c;
    }

    public static Rationaldigit operator -(Rationaldigit a)
    {
            Rationaldigit c = new(0, 1);
            c.Numerator = a.Numerator;
            c.Denominator = a.Denominator;
            if (a.Numerator > 0 || a.Denominator > 0)
            {
                if (a.Numerator > 0 && a.Denominator > 0)
                {
                    c.Numerator = 0 - a.Numerator;
                }
                else if (a.Numerator>0)
                    c.Numerator = 0 - a.Numerator;
                else if (a.Denominator > 0)
                    c.Denominator = 0 - a.Denominator;
            }
            else
            {
                c.Numerator = 0 - a.Numerator;
                c.Denominator = 0 - a.Denominator;
            }
            if(c.Numerator < 0 && c.Denominator<0) {
                c.Numerator = Math.Abs(c.Numerator);
                c.Denominator=Math.Abs(c.Denominator);
            }
            return c;
    }

    public static bool operator ==(Rationaldigit a, Rationaldigit b)
    {
            if (a.Denominator == b.Denominator && a.Numerator == b.Numerator)
                return true;
            else return false;
    }

    public static bool operator !=(Rationaldigit a, Rationaldigit b)
    {
            if (a.Denominator != b.Denominator || a.Numerator != b.Numerator)
                return true;
            else return false;    
    }
    public static bool operator >(Rationaldigit a, Rationaldigit b)
    {
            double a1 = a.Numerator / a.Denominator;
            double b1 = b.Numerator / b.Denominator;
            if (a1 > b1)
                return true;
            else
                return false;
    }

    public static bool operator <(Rationaldigit a, Rationaldigit b)
    {
            double a1 = a.Numerator / a.Denominator;
            double b1 = b.Numerator / b.Denominator;
            if (a1 < b1)
                return true;
            else
                return false;
    }

    public static bool operator >= (Rationaldigit a, Rationaldigit b)
    {
            double a1 = a.Numerator / a.Denominator;
            double b1 = b.Numerator / b.Denominator;
            if (a1 >= b1)
                return true;
            else
                return false;
    }

    public static bool operator <= (Rationaldigit a, Rationaldigit b)
    {
            double a1 = a.Numerator / a.Denominator;
            double b1 = b.Numerator / b.Denominator;
            if (a1 <= b1)
                return true;
            else
                return false;
    }

    private void Reduction()
    {
        int lower = Math.Abs(Numerator);
        int i = 2;
        if (Math.Abs(Denominator) < Math.Abs(Numerator))
        {
            lower = Math.Abs(Denominator);
        }
        while (i <= lower)
        {
            if ((Denominator % i == 0) && (Numerator % i == 0))
            {
                Denominator /= i;
                Numerator /= i;
                i = 2;
                continue;
            }
            i++;
        }
    }
}

class Program
{
    static void Main()
    {
    }
}