using System;
using System.Collections.Generic;
using System.Text;

namespace L2_Z5
{
    class Program
    {
        static void Main(string[] args)
        {
            //���������� ����������
            int money;
            int valuta;
            const int cfunt = 77;
            const int cevro = 65;
            const int cdollar = 63;
            //���� ������ ��� �������� � ������ ������
            Console.WriteLine("������� ����� ��� �������� � ������ ������");
            if (int.TryParse(Console.ReadLine(), out money)) 
            {
                Console.WriteLine("�������� ����� ������:");
                Console.WriteLine("1 ��� �������");
                Console.WriteLine("2 ��� ������;");
                Console.WriteLine("3 ��� ����;");
                Console.WriteLine("4 ��� ����.");
                int.TryParse(Console.ReadLine(), out valuta);
                //����� ������
                switch (valuta)
                {
                    case 1 :
                        double dollar = money / cdollar;
                        Console.WriteLine(dollar + " �������/������/��������.");
                        break;
                    case 2:
                        double funt = money / cfunt;
                        Console.WriteLine(funt + " ����.");
                        break;
                    case 3:
                        double evro = money / cevro;
                        Console.WriteLine(evro + " ����.");
                        break;
                    case 4:
                        Console.WriteLine(money + " ����.");
                        break;
                    default :
                        Console.WriteLine("�� ������� �����.");
                        break;
                };
            }
            else
            {
                Console.WriteLine("�������� ��������! ������� ����� �����.");
            };
            Console.ReadKey();
        }
    }
}
