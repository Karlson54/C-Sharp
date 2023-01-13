using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace lab10.controllers
{
    public static class Reverses
    {
        public static string Reverse(this int integer)
        {
            string result = "";
            while (integer != 0)
            {
                result += integer % 10;
                integer /= 10;
            }

            return result;
        }

        public static string Reverse(this string str)
        {
            string result = "";
            for (int i = str.Length - 1; i > -1; i--)
            {
                result += str[i];
            }

            return result;
        }


        public static string Reverse(this double doubl)
        {
            string[] strArr = doubl.ToString().Split(',');
            return Reverse(strArr[0]) + "." + Reverse(strArr[1]);

        }

        public static string Reverse(this string str, char magicSymbol)
        {
            string[] strArr = str.Split(magicSymbol);
            string result = "";
            foreach (string i in strArr)
            {
                result += Reverse(i) + magicSymbol;
            }

            return result.Substring(0, result.Length - 1);
        }

        public static T[] Reverse<T>(this T[] arr)
        {
            T[] reverseArr = new T[arr.Length];
            for (int j = 0, i = arr.Length - 1; i > -1; i--, j++)
            {
                reverseArr[j] = arr[i];
            }


            return reverseArr;
        }
    }
}