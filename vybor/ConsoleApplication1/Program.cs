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
            int.TryParse(Console.ReadLine(), out A);
            int.TryParse(Console.ReadLine(), out B);
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
            // завершение программы
            Console.ReadKey();
        }
    }
}
