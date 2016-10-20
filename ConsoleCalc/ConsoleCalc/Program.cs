using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1 = 0; // операнды 1
            double operand2 = 0; // операнд 2
            double result = 0; // результат вычисления
            string operation; // действие

            if (double.TryParse(Console.ReadLine(), out operand1) && double.TryParse(Console.ReadLine(), out operand2))
            {
                // выбираем операцию
            operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    if (double.TryParse(Console.ReadLine(), out operand2))
                    {
                        result = operand1 + operand2;
                    };
                    break;
                case "-": 
                    if (double.TryParse(Console.ReadLine(), out operand2))
                    {
                        result = operand1 - operand2;
                    };
                    break;
                case "*": 
                    if (double.TryParse(Console.ReadLine(), out operand2))
                    {
                        result = operand1 * operand2;
                    };
                    break;
                case "/": 
                    if (double.TryParse(Console.ReadLine(), out operand2))
                    {
                        result = operand1 / operand2;
                    };
                    break;
                case "sqrt":
                    if (double.TryParse(Console.ReadLine(), out operand2))
                    {
                        result = Math.Sqrt(operand1) ;
                    };
                    break;
                default: Console.WriteLine("Неверная операция!"); result = 0;
                    break;
            };
            //выводим результат
            Console.WriteLine(operand1 + " " + operation + " " + operand2 + " = " + result);
            }
            else
            {
                Console.WriteLine("Операнд должен быть числом!"); 
            };
    
        }
    }
}
