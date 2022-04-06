using System;
namespace zadanie1
{
    class Program
    {
        static void Main()
        {
            double a, b, d, p, s;
            Console.WriteLine("Введите стороны прямоугольника (a,b): ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            d = Math.Sqrt(a * a + b * b);
            p = (a + b) * 2;
            s = a * b;
            Console.WriteLine("Периметр прямоугольника равен " + p);
            Console.WriteLine("Площадь прямоугольника равна " + s);
            Console.WriteLine("Диагональ прямоугольника равна " + d);
            Console.ReadLine();
        }
    }
}
