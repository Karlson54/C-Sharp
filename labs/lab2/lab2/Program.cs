using System;

namespace classwork
{
    class Program
    {
        static void Check(int nn, int nk)
        {
            if (nn <= nk && nk >= 0 && nn >= 0)
            {
            }
            else
            {
                Console.WriteLine("Неправильные значения!!!");
            }
        }
        static void Main(string[] args)
        {
            int nn, nk, k;
            Console.WriteLine("От скольки?");
            nn = int.Parse(Console.ReadLine());
            Console.WriteLine("До скольки?");
            nk = int.Parse(Console.ReadLine());
            Check(nn, nk);
            double res = 0;
            for (k = nn; k <= nk; k++)
            {
                res += (Math.Pow(-1, k) * Math.Pow(k, 2) - 1) / (Math.Pow(k, 2) + 3);
            }
            Console.WriteLine($"Ответ: {res}");
            Console.ReadKey();
        }
    }
}