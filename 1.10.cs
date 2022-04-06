using System;
namespace zadanie1
{
    class Program
    {
        static void Main()
        {
            double s, pi, v, r, h;
            Console.WriteLine("радиус цилиндра r и высота цилиндра h=: ");
            r = Convert.ToDouble(Console.ReadLine());
            h = Convert.ToDouble(Console.ReadLine());
            pi = 3.14;
            v = pi * (r * r) * h;
            s = 2 * pi * r * h;
            Console.WriteLine("v=" + v);
            Console.WriteLine("s=" + s);
            Console.ReadLine();
        }
    }
}
