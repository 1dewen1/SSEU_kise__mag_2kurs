using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // ���������� �����
            int N;
            int x;
            Console.Write("������� ���������� ����� ��� ������������: ");
            if (int.TryParse(Console.ReadLine(), out N))
            {
                int i = 0; // ������� ���������� ���������
                int Sum = 0; // ����� �����
                // N ���
                while (i < N)
                {
                    Console.Write("������� �����:");
                    // ���� ������� ���������� �����
                    if (int.TryParse(Console.ReadLine(), out x))
                    {
                        Sum += x; //�������� � �����
                        
                        Console.WriteLine("{" + Sum + "}");
                        
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("�������� ��������! ������� ����� ��������!");
                    };

                };
                // ����� ����������
                Console.WriteLine("�����: " + Sum);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("�������� ��������! ������� ����� ��������!");
                Console.ReadKey();
            };
        }
    }
}

