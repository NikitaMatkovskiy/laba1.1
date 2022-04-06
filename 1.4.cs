using System;
namespace zadanie1
{
    class Program
    {
        static void Main()
        {
            double a, b, p, c, s;
            Console.WriteLine("введите стороны треугольника a, b, c: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            p = (a + b + c) / 2;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("s треугольника = " + s);
            Console.ReadLine();
        }
    }
}
