using System;
using System.Collections.Generic;
using System.Text;

namespace L3_Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите число для вычисления факториала.");
            int.TryParse(Console.ReadLine(), out n);
            int fack = 1;
            for (int i = 2; i <= n; i++)
            {
                fack *= i;
            }
            Console.WriteLine("Факториал = " + fack);
            Console.ReadKey();
        }
    }
}
