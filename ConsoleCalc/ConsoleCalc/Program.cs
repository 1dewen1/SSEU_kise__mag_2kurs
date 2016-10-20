using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1; // операнды 1
            double operand2; // операнд 2
            double result = 0; // результат вычисления
            string operation; // действие

            Console.ReadKey();
           
            if (double.TryParse(Console.ReadLine(), out operand1) && double.TryParse(Console.ReadLine(), out operand2))
            {

            }
            else
            {
                Console.WriteLine("Операнд должен быть числом!"); 
            };
            // выбираем операцию
            operation = Console.ReadLine();
            switch (operation)
            {
                case "+": break;
                case "-": break;
                case "*": break;
                case "/": break;
                case "sqrt": break;
                default: Console.WriteLine("Неверная операция!"); result = 0; break;
            };
            //выводим результат
            Console.WriteLine(operand1 + " " + operation + " " + operand2 + " = " + result);
        }
    }
}
