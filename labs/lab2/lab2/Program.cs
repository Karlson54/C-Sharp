﻿using System;

namespace classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            int nn, nk, k;
            double res = 0;
            Console.WriteLine("От скольки?");
            nn = int.Parse(Console.ReadLine());
            Console.WriteLine("До скольки?");
            nk = int.Parse(Console.ReadLine());
            for (k = nn; k <= nk; k++)
            {
                res += (Math.Pow(-1, k) * Math.Pow(k, 2) - 1) / (Math.Pow(k, 2) + 3);
            }
            Console.WriteLine($"Ответ: {res}");
            Console.ReadKey();
        }
    }
}