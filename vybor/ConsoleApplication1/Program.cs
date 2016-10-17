using System;
using System.Collections.Generic;
using System.Text;

namespace vybor
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод исходных значений
            int A, B;
            if (int.TryParse(Console.ReadLine(), out A))
            {
                if (int.TryParse(Console.ReadLine(), out B))
                {
                    // максимальное значение 
                    int Max;
                    // если больше a
                    if (A >= B)
                    {
                        Max = A;
                    }
                    // иначе - больше b
                    else
                    {
                        Max = B;
                    };
                    // вывод результата
                    Console.WriteLine("Максимальное = " + Max);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Неверное значение!Нужно ввести целое число.");
                    Console.ReadKey();
                };
            {
                Console.WriteLine("Неверное значение! Нужно ввести целое число.");
                Console.ReadKey();
            };
            }
        }
    }
}