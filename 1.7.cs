using System;
namespace zadanie1
{
    class Program
    {
        static void Main()
        {
            double s, pi, l, d, r;
            Console.WriteLine("площадь круга S=: ");
            s = Convert.ToDouble(Console.ReadLine());
            pi = 3.14;
            r = Math.Sqrt(s / pi);
            d = r * 2;
            l = 2 * pi * r;
            Console.WriteLine("d=" + d);
            Console.WriteLine("l=" + l);
            Console.ReadLine();
        }
    }
}
