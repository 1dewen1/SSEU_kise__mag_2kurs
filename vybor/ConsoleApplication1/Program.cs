using System;
using System.Collections.Generic;
using System.Text;

namespace vybor
{
    class Program
    {
        static void Main(string[] args)
        {
            //���� �������� ��������
            int A, B;
            if (int.TryParse(Console.ReadLine(), out A))
            {
                if (int.TryParse(Console.ReadLine(), out B))
                {
                    // ������������ �������� 
                    int Max;
                    // ���� ������ a
                    if (A >= B)
                    {
                        Max = A;
                    }
                    // ����� - ������ b
                    else
                    {
                        Max = B;
                    };
                    // ����� ����������
                    Console.WriteLine("������������ = " + Max);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("�������� ��������!����� ������ ����� �����.");
                    Console.ReadKey();
                };
            {
                Console.WriteLine("�������� ��������! ����� ������ ����� �����.");
                Console.ReadKey();
            };
            }
        }
    }
}