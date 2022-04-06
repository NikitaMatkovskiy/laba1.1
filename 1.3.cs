using System;
namespace zadanie1
{
    class Program
    {
        static void Main()
        {
            double a, b, p, s;
            Console.WriteLine("введите сторону 'A' и введите периметр 'P': ");
            a = Convert.ToDouble(Console.ReadLine());
            p = Convert.ToDouble(Console.ReadLine());
            b = p / 2 - a;
            s = a * b;
            Console.WriteLine("s прямоугольника = " + s);
            Console.ReadLine();
        }
    }
}
