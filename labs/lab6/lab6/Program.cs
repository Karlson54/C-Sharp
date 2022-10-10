using System;

namespace lab6
{
    class Program
    {
        static void Reverse(int value)
        {
            string valueS = value.ToString();
            char[] num = valueS.ToCharArray();
            Array.Reverse(num);
            Console.WriteLine(num);
        }
        static void Reverse(string value)
        {
            char[] word = value.ToCharArray();
            Array.Reverse(word);
            Console.WriteLine(word);
        }

        //6 задание

        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(new string('-', 30));
            int check;
            bool succes = int.TryParse(word, out check);
            if (succes)
            {
                int num = int.Parse(word);
                Reverse(num);
            }
            else
            {
                Reverse(word);
            }
            Console.ReadLine();
        }
    }
}