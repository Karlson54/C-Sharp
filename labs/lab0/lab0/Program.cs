using System;

namespace lab0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("какие символы использовать");
            string sim = Console.ReadLine();
            //char[] letters = sim.ToCharArray();
            Random rand = new Random();

            for (int i = 1; i <= 999; i++)
            {
                string password = "";
            Pass:
                Console.WriteLine("длина пароля");
                try
                {
                    int count = int.Parse(Console.ReadLine());
                    for (int j = 1; j <= count; j++)
                    {
                        int letter_num = rand.Next(0, sim.Length);
                        password += sim[letter_num];
                    }
                    if (count == 100)
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный тип данных!!!");
                    Console.ReadKey();
                    //return;
                    goto Pass;
                }
                Console.WriteLine(password);
                Console.ReadKey();
            }
        }
    }
}
