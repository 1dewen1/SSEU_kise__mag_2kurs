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
            Console.WriteLine("Введите сторону a");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введите сторону b");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Введите сторону c");
            double.TryParse(Console.ReadLine(), out c);
            if ((a < b + c) && (b < a + c) && (c < a + b))
            {
                Console.WriteLine("Треугольник является невырожденным");
                
            }

            else
            {
                Console.WriteLine("Треугольник является вырожденным");
                Environment.Exit(0);
            };
            if (a == b && b == c && a == c)
            {
                Console.WriteLine("Треугольник является равносторонним");
            }
            else if (a == b)   
            {
                Console.WriteLine("Треугольник является равнобедренным");
            }
            else if (a == c)
            {
                Console.WriteLine("Треугольник является равнобедренным");
            }
            else if (b == c)
            {
                Console.WriteLine("Треугольник является равнобедренным");
            };
            // выявление бОльшей стороны 
            double tCos;
            if ((a >= b) && (a >= c))
            {
                // максимальное число - a
                tCos = (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2)) / (2 * (b * c));
                if (tCos > 0)
                {
                    Console.WriteLine("Треугольник является остроугольным");
                }
                else if (tCos == 0)
                {
                    Console.WriteLine("Треугольник является прямоугольным");
                }
                else
                {
                    Console.WriteLine("Треугольник является тупоугольным");
                };

            }
            else if ((b >= a) && (b >= c))
            {
                // максимальное число - b
                tCos = (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2)) / (2 * (a * c));
                if (tCos > 0)
                {
                    Console.WriteLine("Треугольник является остроугольным");
                }
                else if (tCos == 0)
                {
                    Console.WriteLine("Треугольник является прямоугольным");
                }
                else
                {
                    Console.WriteLine("Треугольник является тупоугольным");
                };
            }
            else
            {
                // максимальное число - c
                tCos = (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2)) / (2 * (a * c));
                if (tCos > 0)
                {
                    Console.WriteLine("Треугольник является остроугольным");
                }
                else if (tCos == 0)
                {
                    Console.WriteLine("Треугольник является прямоугольным");
                }
                else
                {
                    Console.WriteLine("Треугольник является тупоугольным");
                };

            }
            double s;
            double p;
            //вычисление площади и периметра
            p = a + b + c;
            s = Math.Sqrt(p * ((p - a) * (p - b) * (p - c)));
            if ((p > 100) && (s > 200))
            {
                Console.WriteLine("Большой треугольник");
            }
            else if ((p < 3) && (s < 1))
            {
                Console.WriteLine("Большой треугольник");
            }
            else 
            {
                Console.WriteLine("Обычный треугольник");
            };
            

            
            
            
             


            Console.ReadKey();
        }
        
    }
}
