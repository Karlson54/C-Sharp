using System;

namespace check
{
    class checks
    {
        public void Check2(string a)
        {
            bool isCorrect = false;
            if (a.Length == 4)
            {
                char[] num = a.ToCharArray();
                Array.Reverse(num);
                int a1 = int.Parse(a);
                string b2 = new string(num);
                int a2 = int.Parse(b2);
                if (a1 == a2)
                {
                    isCorrect = true;
                    Console.WriteLine($"{a1} = {a2} {isCorrect}");
                }
                else
                {
                    Console.WriteLine($"{a1} != {a2} {isCorrect}");
                }

            }
            else
            {
                Console.WriteLine("4 цифры!!!");
                a = Console.ReadLine();
                Check2(a);
            }
        }
    }
}
