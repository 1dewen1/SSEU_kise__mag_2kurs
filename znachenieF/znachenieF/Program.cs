using System;
using System.Collections.Generic;
using System.Text;

namespace znachenieF
{
    class Program
    {
        static void Main(string[] args)
        {
            // объявление перенных
            double x;
            double.TryParse(Console.ReadLine(), out x);
            // нахождение функции f(x) 
            double func = - x / 25 * Math.Sqrt((Math.Pow(x, 2)) + 2 * x + 1993);
            // Вывод на экран результата
            Console.WriteLine("Значение функции f(x)=" + func);
            Console.ReadKey();
        }
    }
}
