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
                    int Max = (A >= B) ? A : B; 
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