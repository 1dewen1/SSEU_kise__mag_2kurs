using System;
using System.Collections.Generic;
using System.Text;

namespace L2_Z5
{
    class Program
    {
        static void Main(string[] args)
        {
            //объявление переменных
            int money;
            int valuta;
            const int cfunt = 77;
            const int cevro = 65;
            const int cdollar = 63;
            //ввод рублей для перевода в другую валюту
            Console.WriteLine("Введите рубли для перевода в другую валюту");
            if (int.TryParse(Console.ReadLine(), out money)) 
            {
                Console.WriteLine("Напишите номер валюты:");
                Console.WriteLine("1 для доллара");
                Console.WriteLine("2 для фунтов;");
                Console.WriteLine("3 для евро;");
                Console.WriteLine("4 для йены.");
                int.TryParse(Console.ReadLine(), out valuta);
                //выбор валюты
                switch (valuta)
                {
                    case 1 :
                        double dollar = money / cdollar;
                        Console.WriteLine(dollar + " доллара/доллар/долларов.");
                        break;
                    case 2:
                        double funt = money / cfunt;
                        Console.WriteLine(funt + " фунт.");
                        break;
                    case 3:
                        double evro = money / cevro;
                        Console.WriteLine(evro + " евро.");
                        break;
                    case 4:
                        Console.WriteLine(money + " йены.");
                        break;
                    default :
                        Console.WriteLine("Не введено число.");
                        break;
                };
            }
            else
            {
                Console.WriteLine("Неверное значение! Введите целое число.");
            };
            Console.ReadKey();
        }
    }
}
