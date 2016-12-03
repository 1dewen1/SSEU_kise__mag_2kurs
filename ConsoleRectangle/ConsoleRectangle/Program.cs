using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRectangle
{
        // прямоугольник
        class Rectangle
        {
            double x1, x2; //верхний левый угол
            double y1, y2; //правый нижний угол

            public Rectangle (double x1, double x2, double y1, double y2)
            {
                // начальные координаты
                this.x1 = x1; this.y1 = y1;
                this.x2 = x2; this.y2 = y2;
            }
        

            
        }

    class Program
    {
        //ввод одной координаты, сообщение message выводится пользователю
        static double ReadCoord(string message)
        {
            double coord;
            Console.Write("Введите координату" + message);
            while (!double.TryParse(Console.ReadLine(), out coord))
            {
                Console.Write("Ошибка! Введите число.");
            };
            return coord;
        }
        static void Main(string[] args)
        {
            Rectangle r; // один прямоугольник 
            Console.Write("Создание прямоугольника");
            // создаем новый прямоугольник с введенными координатами
            r = new Rectangle(ReadCoord("x верхнего левого угла"),
                              ReadCoord("y верхнего левого угла"),
                              ReadCoord("x нижнего правого угла"),
                              ReadCoord("y нижнего правого угла"));
            char key; // нажатая клавиша
            do
            {
                Console.Clear(); //очистка окна
                //вывод координат
                Console.WriteLine("Верхний левый угол: x =" + r.x1 + ", y = " + r.y1);
                Console.WriteLine("Нижний правый угол: x =" + r.x2 + ", y = " + r.y2);

                //нажатие клавиши
                key = Console.ReadKey().KeyChar;
            }
            while (key != (char)27); //пока не нажат Esc


        }
        
    }

}
