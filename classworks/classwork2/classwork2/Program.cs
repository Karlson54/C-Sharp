using System;

namespace classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            int nn, nk, k;
            double res = 0;
            nn = int.Parse(Console.ReadLine());
            nk = int.Parse(Console.ReadLine());
            for (k = nn; k <= nk; k++)
            {
                res += 2 * Math.Pow(k, 2);
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
