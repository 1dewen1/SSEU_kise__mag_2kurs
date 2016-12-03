using System;
using System.Collections.Generic;
using System.Text;

namespace L1_Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            // объ€вление переменных
            double x;
            double a;
            double b;
            double c;
            Console.WriteLine("¬ведите значение x");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("¬ведите день рождени€");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("¬ведите мес€ц дн€ рождени€");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("¬ведите год рождени€");
            double.TryParse(Console.ReadLine(), out c);
            //¬ычисление f(x)
            double fun = (-1*x)/a*Math.Sqrt(Math.Pow(x, 2) + b*x + c);
            //вывод значени€ функции f(x)
            Console.WriteLine("«начение функции = " + fun);
            
            
            
            
            
            Console.ReadKey();
        }
    }
}
