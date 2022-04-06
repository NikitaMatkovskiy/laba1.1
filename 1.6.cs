using System;
namespace zadanie1
{
    class Program
    {
        static void Main()
        {
            double r1, r2, s1, s2, s3, pi;
            Console.WriteLine("введите r1 и r2, где r1>r2: ");
            r1 = Convert.ToDouble(Console.ReadLine());
            r2 = Convert.ToDouble(Console.ReadLine());
            pi = 3.14;
            s1 = pi * (Math.Sqrt(r1));
            s2 = pi * (Math.Sqrt(r2));
            s3 = s1 - s2;
            Console.WriteLine("s1=" + s1);
            Console.WriteLine("s2=" + s2);
            Console.WriteLine("s3=" + s3);
            Console.ReadLine();
        }
    }
}
