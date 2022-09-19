using System;

namespace lab3
{
    class lab3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("11 задание");
        again:
            string a1 = Console.ReadLine();
            bool isCorrect = false;
            if (a1.Length <= 4)
            {

                try
                {
                    int c1 = int.Parse(a1);
                    string b1 = a1.ToString();
                    char[] num = b1.ToCharArray();
                    Array.Reverse(num);
                    string b2 = new string(num);
                    int a2 = int.Parse(b2);
                    if (c1 == a2)
                    {
                        isCorrect = true;
                    }
                    Console.WriteLine(isCorrect);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Цифры!!!");
                }
            }
            else
            {
                Console.WriteLine("не больше 4!!!");
                goto again;
            }
            Console.ReadKey();
        }
    }
}