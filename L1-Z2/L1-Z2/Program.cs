using System;
using System.Collections.Generic;
using System.Text;

namespace L1_Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double a;
            double b;
            double c;
            Console.WriteLine("������� �������� x");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("������� ���� ��������");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("������� ����� ��� ��������");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("������� ��� ��������");
            double.TryParse(Console.ReadLine(), out c);
            double fun = (-1*x)/a*Math.Sqrt(Math.Pow(x, 2) + b*x + c);
            Console.WriteLine("�������� ������� = " + fun);
            
            
            
            
            
            Console.ReadKey();
        }
    }
}