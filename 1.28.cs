using System;
namespace zadanie1
{
    class Program
    {
        static void Main()
        {
            double a, b, c, d, e;
            Console.WriteLine("введите стоимость товара: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите скидку в % ");
            b = Convert.ToDouble(Console.ReadLine());
            c = (a * b) / 100;
            d = a - c;
            e = a - d;
            Console.WriteLine("стоимость товара по скидке=" + d);
            Console.WriteLine("покупатель сэкономил=" + e);
            Console.ReadLine();

        }
    }
}
