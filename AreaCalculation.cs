using System;

namespace AreaCalculation
{
    public class Figure
    {
        protected const double pi = 3.1415926535;

        public virtual double CalculateArea(double a, double b, double c)
        {
            if (a < b + c && b < c + a && c < a + b)
            {
                double halfMeter = (a + b + c) / 2;
                return Math.Sqrt(halfMeter * (halfMeter - a) * (halfMeter - b) * (halfMeter - c));
            }
            else
            {
                throw new ArgumentException("Сумма двух сторон треугольника должна быть больше длины третьей");
            }
        }

        public virtual double CalculateArea(double r)
        {
            return pi * r * r;
        }
    }

    public class Triangle : Figure
    {
        double a, b, c, h;
        string name;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            name = "Common";
        }

        public Triangle(double b, double h)
        {
            this.b = b;
            this.h = h;
            name = "Rectangular";
        }

        public double CalculateArea()
        {
            switch (name)
            {
                case "Common":
                    return CalculateArea(a, b, c);
                case "Rectangular":
                    return CalculateArea(b, h);
                default:
                    throw new ArgumentException("Invalid triangle");
            }
        }

        double CalculateArea(double b, double h)
        {
            return b * h / 2;
        }
    }

    public class Circle : Figure
    {
        double r;

        public Circle(double r)
        {
            this.r = r;
        }

        public double CalculateArea()
        {
            return CalculateArea(r);
        }
    }

}
