using System;
namespace zadanie1
{
    class Program
    {
        static void Main()
        {
            double v1, v2, s, t, st;
            Console.WriteLine("Скорость первого автомобиля V1 км/ч: ");
            v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Скорость второго автомобиля V2 км/ч: ");
            v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите  расстояние между ними S км: ");
            s = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("время которое проехали автомобили T=: ");
            t = Convert.ToDouble(Console.ReadLine());
            st = s - t * (v1 + v2);
            Console.WriteLine($"Расстояние между автомобилями через {t}часов=: {st}");
            Console.ReadLine();

        }
    }
}
