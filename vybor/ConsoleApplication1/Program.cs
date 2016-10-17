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
            int A, B, C;
            if (int.TryParse(Console.ReadLine(), out A) && int.TryParse(Console.ReadLine(), out B)
                && int.TryParse(Console.ReadLine(), out C))
                {
                    // максимальное значение 
                    int Max = ((Max = (A >= B) ? A : B) >= C) ? Max : C;
                    // вывод результата
                    Console.WriteLine("Максимальное = " + Max);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Неверное значение!Нужно ввести целое число.");
                    Console.ReadKey();
                };
            
            }
        }
    }
