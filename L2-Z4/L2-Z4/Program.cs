using System;
using System.Collections.Generic;
using System.Text;

namespace L2_Z4
{
    class Program
    {
        static void Main(string[] args)
        {
                        double a;
            double b;
            double c;
            Console.WriteLine("������� ������� a");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("������� ������� b");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("������� ������� c");
            double.TryParse(Console.ReadLine(), out c);
            if ((a < b + c) && (b < a + c) && (c < a + b))
            {
                Console.WriteLine("����������� �������� �������������");
                Console.ReadKey();
            }
            
        }
    }
}
