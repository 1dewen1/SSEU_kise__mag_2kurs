using System;
using System.Collections.Generic;
using System.Text;

namespace CinF
{
    class Program
    {
        static void Main(string[] args)
        {
           // объявление переменных
           double cel;
           double.TryParse(Console.ReadLine(), out cel);
           // перевод градусов Цельсия в градусы Фарингейта
           double cinf = (cel * 1.8) + 32;
           // вывод значения
           Console.WriteLine(cinf + " градусов фарингейта");
           Console.ReadKey();
        }
    }
}
