using System;
using check;

namespace lab3
{
    class lab3
    {
        static string Check1(out string b)
        {
            try
            {
                Console.WriteLine("Введите число");
                int a = int.Parse(Console.ReadLine());
                b = a.ToString();
                return b;
            }
            catch (FormatException)
            {
                Console.WriteLine("Цифры!!!");
                return Check1(out b);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("11 задание");
            checks check = new checks();
            Check1(out string b);
            check.Check2(b);
            Console.ReadKey();
        }
    }
}