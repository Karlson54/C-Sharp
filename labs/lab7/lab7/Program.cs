using System;
using System.Collections.Generic;

namespace lab7
{
    class Program
    {
        //Задание 6
        //Створити ліст інтових змінних, який може вміщати тільки 1 і 0,
        //заповнити його з клавіатури. Порахувати кількість 1 і 0.
        //Скопіювати отриманий ліст в масив.
        static int Check(out int nums)
        {
            nums = int.Parse(Console.ReadLine());
            if (nums == 1 || nums == 0)
            {
                return nums;
            }
            else
            {
                Console.WriteLine("Только '1' или '0'");
                return Check(out nums);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество значений в листе:");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 20));
            int[] array = new int[amount];
            List<int> numbers = new List<int>(amount);
            int nums, one = 0, zero = 0;
            Console.WriteLine("Введите числа через Enter");
            for (int i = 0; i < amount; i++)
            {
                Check(out nums);
                numbers.Add(nums);
            }
            Console.WriteLine(new string('-', 20));
            numbers.CopyTo(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 1)
                {
                    one += 1;
                }
                else
                {
                    zero += 1;
                }
            }
            Console.WriteLine($"1 = {one}, 0 = {zero}");
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}