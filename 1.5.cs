using System;
namespace zadanie1
{
    class Program
    {
        static void Main()
        {
            double s, r, П, v;
            Console.WriteLine("введите радиус шара r=: ");
            r = Convert.ToDouble(Console.ReadLine());
            П = 3.14;
            v = (4 / 3) * П * (r * r * r);
            s = 4 * П * (r * r);
            Console.WriteLine("s шара = " + s);
            Console.WriteLine("v шара = " + v);
            Console.ReadLine();
        }
    }
}
