using System;
namespace zadanie1
{
    class Program
    {
        static void Main()
        {
            double s, pi, l, r;
            Console.WriteLine("длина окружности L=: ");
            l = Convert.ToDouble(Console.ReadLine());
            pi = 3.14;
            r = l / 2 * pi;
            s = pi * (r * r);
            Console.WriteLine("r=" + r);
            Console.WriteLine("s=" + s);
            Console.ReadLine();
        }
    }
}
