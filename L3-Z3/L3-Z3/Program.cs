using System;
using System.Collections.Generic;
using System.Text;

namespace L3_Z3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; //ввод длины массива
            do
            {
                Console.Write("Введите длину массива: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0));
            //инициализация массива
            int[] a = new int[n];
            //ввод значений массива
            int i = 0;
            while (i < n)
            {
                Console.Write("Введите a[" + i + "]: ");
                if (int.TryParse(Console.ReadLine(), out a[i]))
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("Введите целое число!");
                }; ;
            };
            //поиск минимального значения
            int min = a[0];
            string iMin = "0";
            for (i = 1; i < a.Length; i++)
            {
                if (a[i] == min)
                {
                   iMin = iMin + ", " + i;
                }
                else if (a[i] < min)
                {
                    min = a[i];
                    iMin = i.ToString();
                };
            };
            //вывод результата
            Console.WriteLine("Минимальное значение a[" + iMin + "] = " + min);
            //выход из программы
            Console.ReadKey();
        }
    }
}
