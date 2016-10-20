using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1 = 0; // �������� 1
            double operand2 = 0; // ������� 2
            double result = 0; // ��������� ����������
            string operation; // ��������

            if (double.TryParse(Console.ReadLine(), out operand1) && double.TryParse(Console.ReadLine(), out operand2))
            {
                // �������� ��������
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
                default: Console.WriteLine("�������� ��������!"); result = 0;
                    break;
            };
            //������� ���������
            Console.WriteLine(operand1 + " " + operation + " " + operand2 + " = " + result);
            }
            else
            {
                Console.WriteLine("������� ������ ���� ������!"); 
            };
    
        }
    }
}
