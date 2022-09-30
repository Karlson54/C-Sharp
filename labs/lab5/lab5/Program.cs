using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
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
            int n, m;
            Console.WriteLine("Введите кол-во строк");
            Check(out n);
            Console.WriteLine("Введите кол-во столбцов");
            Check(out m);
            int[,] mas = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Введите {i}:{j}");
                    Check(out mas[i, j]);
                }
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
