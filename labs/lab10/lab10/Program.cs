using lab10.controllers;
using System;

namespace lab6
{
    public static class Printer
    {
        public static void PrintArr<T>(this T[] arr)
        {
            foreach (T element in arr)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
        }
    }
    class Program
    {


        //6 задание

        static void Main(string[] args)
        {
            Console.WriteLine($"{434534.Reverse()} {21321.44.Reverse()} {"ABD".Reverse()} {"ABD,DBA".Reverse()}");
            new int[] { 1, 2, 3, 4 }.Reverse().PrintArr();
            new int[] { 4, 5, 32, 7, }.Sort().PrintArr();
            Console.ReadKey();
        }
    }
    public static class Extension
    {
        public static int[] Sort(this int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }
    }
}