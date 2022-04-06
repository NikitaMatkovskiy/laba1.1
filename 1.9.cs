using System;
namespace zadanie1
{
    class Program
    {
        static void Main()
        {
            double s, pi, l, r, d;
            Console.WriteLine("диаметр окружности d=: ");
            d = Convert.ToDouble(Console.ReadLine());
            pi = 3.14;
            r = d / 2;
            l = 2 * pi * r;
            s = pi * (r * r);
            Console.WriteLine("l=" + l);
            Console.WriteLine("s=" + s);
            Console.ReadLine();
        }
    }
}
