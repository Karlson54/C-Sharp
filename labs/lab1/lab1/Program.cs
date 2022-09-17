using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 задание");
            double T, g = 9.8;
            Console.WriteLine("Введите длину нити");
            double L = double.Parse(Console.ReadLine());
            T = 2 * Math.PI * Math.Sqrt(L / g);
            Console.WriteLine($"{T} секунд");


            Console.WriteLine("2 задание");
            double I, U;
            bool isOK = false;
            do
            {
                Console.WriteLine("Введіть напругу:");
                string strU = Console.ReadLine();
                isOK = double.TryParse(strU, out U);
                if (!isOK)
                {
                    Console.WriteLine("Погане слово");
                }
            }
            while (!isOK);
            Console.WriteLine("Введіть опір:");
            double strR = double.Parse(Console.ReadLine());
            if (strR <= 0)
            {
                Console.WriteLine("Теж погане слово!");
                Console.ReadLine();
                return;
            }
            I = U / strR;
            Console.WriteLine($"Держи {I}");


            Console.WriteLine("3 задание");
            int v = int.Parse(Console.ReadLine());
            var Time = TimeSpan.FromSeconds(v);

            Console.WriteLine($"{Time.Days} д. {Time.Hours} ч. {Time.Minutes} м {Time.Seconds} с.");

            Console.ReadKey();
        }
    }
}