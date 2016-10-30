using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // количество чисел
            int N;
            int x;
            Console.Write("Ввидите количество чисел для суммирования: ");
            if (int.TryParse(Console.ReadLine(), out N))
            {
                int i = 0; // счетчик количества введенных
                int Sum = 0; // сумма чисел
                // N раз
                do
                {
                    Console.Write("Введите число:");
                    // если введено корректное число
                    if (int.TryParse(Console.ReadLine(), out x))
                    {
                        Sum += x; //добавить к сумме
                        /* DEBUG INFO
                        Console.WriteLine("{" + Sum + "}");
                        //*/
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Неверное значение! Введите целое значение!");
                    };

                }
                while (i < N);
                // вывод результата
                Console.WriteLine("Сумма: " + Sum);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Неверное значение! Введите целое значение!");
                Console.ReadKey();
            };
        }
    }
}

