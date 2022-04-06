using System;
namespace zadanie1
{
    class Program
    {
        static void Main()
        {
            double a, b, c, v, s;
            Console.WriteLine("длины ребер a, b, c прямоугольного параллелепипеда: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            v = a * b * c;
            s = (a * b + b * c + a * c);
            Console.WriteLine("v= " + v);
            Console.WriteLine("s поверхности= " + s);
            Console.ReadLine();
        }
    }
}
