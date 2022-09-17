using System;

namespace classwork1
{
    class Program
    {
        static void Main(string[] args)
        {
            //i=u/r
            //r- омы
            //u - вольт
            //i - ампери
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
            Console.ReadKey();
        }
    }
}
