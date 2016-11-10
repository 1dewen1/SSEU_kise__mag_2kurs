using System;
using System.Collections.Generic;
using System.Text;

namespace Identificator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите идентификатор");
            string id = Console.ReadLine(); //идентификатор
            //проверка первого символа
            if (!((id[0] >= 'a') && (id[0] <= 'z') //не строчная буква
               || (id[0] >= 'A') && (id[0] <= 'Z') //или заглавная буква
               || (id[0] == '_'))) //или подчеркивание
            {
                Console.WriteLine("Первый символ должен быть буквой или знаком подчеркивания!");
                Console.ReadKey();
            }

        }
    }
}
