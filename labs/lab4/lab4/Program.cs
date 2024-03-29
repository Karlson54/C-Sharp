﻿using System;

namespace lab4
{
    class Program
    {
        static int Check(out int countmass)
        {
            try
            {
                countmass = int.Parse(Console.ReadLine());
                return countmass;
            }
            catch (FormatException)
            {
                Console.WriteLine("Цифры!!!");
                return Check(out countmass);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("20 задание");
            Console.WriteLine("Введите количество строк, которые хотите ввести:");
            Check(out int countmass);
            int[] strs = new int[countmass];
            for (int i = 1; i <= countmass; i++)
            {
                Console.WriteLine($"Введите строку №{i}");
                Check(out int mass);
                strs[i - 1] = mass;
            }
            Array.Sort(strs);
            int maxCount = -1, maxCountKey = 0;
            int currCount = 0, currCountKey = strs[0];
            foreach (int curr in strs)
            {
                if (curr == currCountKey)
                    currCount++;
                else
                {
                    currCount = 1;
                    currCountKey = curr;
                }
                if (currCount > maxCount)
                {
                    maxCount = currCount;
                    maxCountKey = curr;
                }
            }
            Console.WriteLine($"Число, которое больше всего повторяется: {maxCountKey}. " +
                $"Количество его повтора: {maxCount}");
            Console.ReadKey();
        }
    }
}