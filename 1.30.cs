using System;
namespace zadanie1
{
    class Program
    {
        static void Main()
        {
            double p, x, y, z;
            Console.WriteLine("введите прибыль цеха в день P=");
            p = Convert.ToDouble(Console.ReadLine());
            x = p * 70 / 100; //вычитаем налог 70%
            y = x * 70 / 100; //30%уйдет на развитие, 70% получат работники
            z = y / 8 * 30; // эти 70% что получат все работники делим на количество работников и умножаем на 30 дней
            Console.WriteLine("среднемесячная заработная плата одного из 8 работников = " + z);
            Console.ReadLine();

        }
    }
}
