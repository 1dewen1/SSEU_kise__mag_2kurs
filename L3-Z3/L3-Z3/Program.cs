using System;
using System.Collections.Generic;
using System.Text;

namespace L3_Z3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; //���� ����� �������
            do
            {
                Console.Write("������� ����� �������: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0));
            //������������� �������
            int[] a = new int[n];
            //���� �������� �������
            int i = 0;
            while (i < n)
            {
                Console.Write("������� a[" + i + "]: ");
                if (int.TryParse(Console.ReadLine(), out a[i]))
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("������� ����� �����!");
                }; ;
            };
            //����� ������������ ��������
            int min = a[0];
            string iMin = "0";
            for (i = 1; i < a.Length; i++)
            {
                if (a[i] == min)
                {
                   iMin = iMin + ", " + i;
                }
                else if (a[i] < min)
                {
                    min = a[i];
                    iMin = i.ToString();
                };
            };
            //����� ����������
            Console.WriteLine("����������� �������� a[" + iMin + "] = " + min);
            //����� �� ���������
            Console.ReadKey();
        }
    }
}
