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
                
            }

            else
            {
                Console.WriteLine("����������� �������� �����������");
                Environment.Exit(0);
            };
            if (a == b && b == c && a == c)
            {
                Console.WriteLine("����������� �������� ��������������");
            }
            else if (a == b)   
            {
                Console.WriteLine("����������� �������� ��������������");
            }
            else if (a == c)
            {
                Console.WriteLine("����������� �������� ��������������");
            }
            else if (b == c)
            {
                Console.WriteLine("����������� �������� ��������������");
            };
            // ��������� ������� ������� 
            double tCos;
            if ((a >= b) && (a >= c))
            {
                // ������������ ����� - a
                tCos = (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2)) / (2 * (b * c));
                if (tCos > 0)
                {
                    Console.WriteLine("����������� �������� �������������");
                }
                else if (tCos == 0)
                {
                    Console.WriteLine("����������� �������� �������������");
                }
                else
                {
                    Console.WriteLine("����������� �������� ������������");
                };

            }
            else if ((b >= a) && (b >= c))
            {
                // ������������ ����� - b
                tCos = (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2)) / (2 * (a * c));
                if (tCos > 0)
                {
                    Console.WriteLine("����������� �������� �������������");
                }
                else if (tCos == 0)
                {
                    Console.WriteLine("����������� �������� �������������");
                }
                else
                {
                    Console.WriteLine("����������� �������� ������������");
                };
            }
            else
            {
                // ������������ ����� - c
                tCos = (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2)) / (2 * (a * c));
                if (tCos > 0)
                {
                    Console.WriteLine("����������� �������� �������������");
                }
                else if (tCos == 0)
                {
                    Console.WriteLine("����������� �������� �������������");
                }
                else
                {
                    Console.WriteLine("����������� �������� ������������");
                };

            }
            double s;
            double p;
            //���������� ������� � ���������
            p = a + b + c;
            s = Math.Sqrt(p * ((p - a) * (p - b) * (p - c)));
            if ((p > 100) && (s > 200))
            {
                Console.WriteLine("������� �����������");
            }
            else if ((p < 3) && (s < 1))
            {
                Console.WriteLine("������� �����������");
            }
            else 
            {
                Console.WriteLine("������� �����������");
            };
            

            
            
            
             


            Console.ReadKey();
        }
        
    }
}
