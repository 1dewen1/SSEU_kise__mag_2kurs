using System;
using System.Collections.Generic;
using System.Text;

namespace L2_Z4
{
    class Program
    {
        static void Main(string[] args)
        {
                        double a;
            double b;
            double c;
            Console.WriteLine("¬ведите сторону a");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("¬ведите сторону b");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("¬ведите сторону c");
            double.TryParse(Console.ReadLine(), out c);
            if ((a < b + c) && (b < a + c) && (c < a + b))
            {
                Console.WriteLine("“реугольник €вл€етс€ невырожденным");
                Console.ReadKey();
            }
            
        }
    }
}
