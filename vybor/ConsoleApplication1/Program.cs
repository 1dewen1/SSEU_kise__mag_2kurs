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
            int.TryParse(Console.ReadLine(), out A);
            int.TryParse(Console.ReadLine(), out B);
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
            // ���������� ���������
            Console.ReadKey();
        }
    }
}
