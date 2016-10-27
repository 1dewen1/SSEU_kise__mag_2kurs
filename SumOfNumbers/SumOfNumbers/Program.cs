using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //количество чисел
            int N;
            int x;
            Console.Write("Введите количество чисел для суммирования: ");
            if (int.TryParse(Console.ReadLine(), out N))
            {
                int Sum = 0; //сумма чисел
                //N раз
                Console.Write("Введите число: ");
                for (int i = 0; i < N; i++)
                {
                    //если введено верное выражене
                    if (int.TryParse(Console.ReadLine(), out x))
                    {
                        Sum += x; //добавить к сумме
                        /* DEBUG INFO
                        Console.WriteLine("{" + Sum + "}");
                        //*/
                    }
                   else
                   {
                        Console.WriteLine("Неверное значение! Введите целое значение");
                        i--;
                   }
                };
                //вывод результата
                Console.WriteLine("Сумма: " + Sum);


            }
            
        }
    }
}

