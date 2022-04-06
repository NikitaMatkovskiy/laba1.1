using System;
namespace zadanie1
{
    class Program
    {
        static void Main()
        {
            double v, u, t1, t2, s;
            Console.WriteLine("Введите скорость лодки в стоячей воде V: ");
            v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость течения реки U: ");
            u = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите время движения лодки по озеру T1: ");
            t1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите время движения по реке(против течения) – T2: ");
            t2 = Convert.ToDouble(Console.ReadLine());
            s = v * t1 + (v - u) * t2;
            Console.WriteLine("лодка прошла расстояние км =" + s);
            Console.ReadLine();

        }
    }
}
