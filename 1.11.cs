using System;
namespace zadanie1
{
    class Program
    {
        static void Main()
        {
            double a, b, h, p, s;
            Console.WriteLine("Введите длину основания a трапеции: ");
            Console.WriteLine("Введите длину основания b трапеции: ");
            Console.WriteLine("Введите высоту h трапеции: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            h = Convert.ToDouble(Console.ReadLine());
            s = Math.Abs(a - b) * h / 2 + Math.Min(a, b) * h;
            p = Math.Sqrt(Math.Pow(Math.Abs(a - b) / 2, 2) + Math.Pow(h, 2)) * 2 + a + b;
            Console.WriteLine("s трапеции =" + s);
            Console.WriteLine("p трапеции =" + p);
            Console.ReadLine();

        }
    }
}
