using System;

namespace lab2ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care va determina daca un numar este sau nu
            palindrom.*/
            Console.WriteLine("Introduceti un numar:");

            int x = int.Parse(Console.ReadLine());
            int y = x;
            int reverse = 0;
            int prov;

            while (y != 0)
            {
                prov = y % 10;
                reverse = reverse * 10 + prov;
                y = y / 10;
            }
            if (x == reverse)
            {
                Console.WriteLine("Numarul introdus este palindrom");
            }
            else
            {
                Console.WriteLine("Numarul introdus nu este palindrom");
            }
        }
    }
}
