using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            char key;  //нажатая клавиша
            string txt = ""; //обрабатываемая строка
            //повторять
            do
            {
                //очистка окна 
                Console.Clear();
                //вывод строки и ее длины
                Console.Write("Строка: " + txt);
                Console.WriteLine(", длина: " + txt.Length);
                //вывод меню
                Console.WriteLine(""); Console.Write(""); Console.Write(""); Console.Write("");
                Console.WriteLine("\t\t\t╔═══════════════════════════╗");
                Console.WriteLine("\t\t\t║          МЕНЮ             ║");
                Console.WriteLine("\t\t\t║  1 - ввести новую строку  ║");
                Console.WriteLine("\t\t\t║  2 - поиск                ║");
                Console.WriteLine("\t\t\t║  3 - замена               ║");
                Console.WriteLine("\t\t\t║  4 - удаление             ║");
                Console.WriteLine("\t\t\t║  5 - вставка              ║");
                Console.WriteLine("\t\t\t║  6 - обрезка              ║");
                Console.WriteLine("\t\t\t║  ESC - выход              ║");
                Console.WriteLine("\t\t\t╚═══════════════════════════╝");
                //считать нажатую клавишу
                key = Console.ReadKey().KeyChar;
                switch (key)
                {
                    case '1': //ввод новой строки 
                        Console.Clear();
                        Console.WriteLine("Введите новую строку:");
                        txt = Console.ReadLine();
                        break;
                    case '2': //поиск подстроки
                        Console.Clear();
                        Console.WriteLine("Строка: " + txt);
                        Console.WriteLine();
                        Console.WriteLine("Введите подстроку для поиска:");
                        string substr = Console.ReadLine();
                        //индекс подстроки
                        int pos = txt.IndexOf(substr);
                        //если индекс отрицательный - подстрока не найдена
                        if (pos >= 0)
                        {
                            Console.WriteLine("Подстрока найдена на символе: " + pos);
                        }
                        else
                        {
                            Console.WriteLine("Подстрока не найдена");
                        };
                        //возврат в главное меню
                        Console.Write("Нажмите любую клавишу для возврата в главное меню...");
                        Console.ReadKey();
                        break;
                    case '3': break;
                    case '4': break;
                    case '5': break;
                    case '6': break;
                };

            }
            while (key != (char)27); //пока не нажат ESC

  
        }
    }
}
