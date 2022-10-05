using System;

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
            Console.WriteLine("24 задание");
            int n, m;
            Console.WriteLine("Введите кол-во строк");
            Check(out n);
            Console.WriteLine("Введите кол-во столбцов");
            Check(out m);
            int num;
            Console.WriteLine("Какое число искать?");
            Check(out num);

            int[,] mas = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Введите {i + 1}:{j + 1}");
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

            int minS = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (num == mas[i, j])
                    {
                        minS = i;
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("Массив переделанный:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i != minS)
                    {
                        Console.Write(mas[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}