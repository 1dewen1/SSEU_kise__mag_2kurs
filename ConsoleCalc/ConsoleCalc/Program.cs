using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1; // �������� 1
            double operand2; // ������� 2
            double result = 0; // ��������� ����������
            string operation; // ��������

            Console.ReadKey();
           
            if (double.TryParse(Console.ReadLine(), out operand1) && double.TryParse(Console.ReadLine(), out operand2))
            {

            }
            else
            {
                Console.WriteLine("������� ������ ���� ������!"); 
            };
            // �������� ��������
            operation = Console.ReadLine();
            switch (operation)
            {
                case "+": break;
                case "-": break;
                case "*": break;
                case "/": break;
                case "sqrt": break;
                default: Console.WriteLine("�������� ��������!"); result = 0; break;
            };
            //������� ���������
            Console.WriteLine(operand1 + " " + operation + " " + operand2 + " = " + result);
        }
    }
}
