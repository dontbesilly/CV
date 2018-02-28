using System;
using AreaCalculation;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5, b = 10, c = 7;
            Console.WriteLine($"Площадь любой фигуры по трём сторонам a={a}, b={b}, c={c}:");
            Console.WriteLine(new Figure().CalculateArea(a, b, c));
            Console.WriteLine();

            double r = 15;
            Console.WriteLine($"Площадь любой фигуры по радиусу r={r}:");
            Console.WriteLine(new Figure().CalculateArea(r));
            Console.WriteLine();

            double h = 20;
            Console.WriteLine($"Площадь прямоугольного треугольника b={b}, h={h}:");
            Console.WriteLine(new Triangle(b,h).CalculateArea());
            Console.WriteLine();

            Console.WriteLine($"Площадь круга r={r}:");
            Console.WriteLine(new Circle(r).CalculateArea());
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
