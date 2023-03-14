using System;

namespace AreaOfMathFigure
{
    public static class AreaOfMathFigure
    {
        static public bool CheckTriangle(double a, double b, double c)
        {
            double[] tmpArray = new double[] { a, b, c };
            Array.Sort(tmpArray);
            return Math.Pow(tmpArray[2], 2) == Math.Pow(tmpArray[0], 2) + Math.Pow(tmpArray[1], 2);
        }
        static public double Area(double R)
        {
            if (R > 0) return Math.PI * Math.Pow(R, 2);
            return 0;
        }
        static public double Area(double a, double b, double c)
        {
            if (!(a > 0 && b > 0 && c > 0)) return 0;
            double[] tmpArray = new double[] { a, b, c };
            Array.Sort(tmpArray);
            if (tmpArray[0] + tmpArray[1] < tmpArray[2]) return 0;

            double p = (double)(a + b + c) / (double)2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        static public double Area(double a, double b)
        {
            if (a > 0 && b > 0) return (a * b);
            return 0;
        }
    }
}