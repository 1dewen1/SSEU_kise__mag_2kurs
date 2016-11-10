using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalc2
{
    class Program
    {
        //ввод операнда с консоли с проверкой значения
        static double ReadOperand()
        {
            double operand = 0; //значение операнда
            Console.Write("Введите число: ");
            //повторять ввод, пока не будет введено корректное значение
            while (!double.TryParse(Console.ReadLine(), out operand))
            {
                Console.Write("Неверное значение! Введите число: ");
            };
            //вернуть значение
            return operand;
        }
        static void Main(string[] args)
        {
            double operand1 =  ReadOperand(); // операнд 1
            double operand2 = 0; // операнд 2
            string operation; // действие

            //повторять ввод операций
            do
            {
                //выбираем операцию 
                Console.Write("Введите операцию:");
                operation = Console.ReadLine();
                operation = operation.ToLower();
                switch (operation)
                {
                    //операции с двумя операндами
                    case "+": case"-": case "*": case "/":
                        //считываем второй операнд 
                        operand2 = ReadOperand();
                        //какая именно операция?
                        switch (operation)
                        {
                            case "+": operand1 = operand1 + operand2; break;
                            case "-": operand1 = operand1 - operand2; break;
                            case "*": operand1 = operand1 * operand2; break;
                            case "/": operand1 = operand1 / operand2; break;
                        };
                        break;
                    //операции с одним операндом
                    case "sqrt": operand1 = Math.Sqrt(operand1); break;
                    //выход из программы
                    case "quit": case "exit" : return;
                    //недопустимые операции 
                    default: Console.WriteLine("Неверная операция!"); break;
                };
                //выводит результат
                Console.WriteLine(" = " + operand1);
            }
            //пока не будет введена команда выхода
        while (!((operation == "quit") || (operation == "exit")));
        }
 
    }
}
