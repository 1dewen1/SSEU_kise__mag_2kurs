using System;
using System.Collections.Generic;
using System.Text;

namespace split2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("������� ����� ����� ;");
            string numbersStr = Console.ReadLine();
            //������� ������ �� ������� ;
            string[] numbersStrArr = numbersStr.Split(';');
            //������ ����� ��� �� �����, ��� � ������ �����
            double[] numbersArr = new double[numbersStrArr.Length];
            //��� ������� �������� �������
            int n = 0;
            for (int i = 0; i < numbersStrArr.Length; i++)
            {
                //����������� ������ ��� �������� � ����� 
                if (double.TryParse(numbersStrArr[i].Trim(), out numbersArr[i]))
                {
                    n++;
                    
                };
            };
            //��������� ������ ������� n
            double[] buffer = new double[n];
            for (int i = 0; i < n; i++)
            {
                //�������� � �����
                buffer[i] = numbersArr[i];
            };
            //�������� ������������ ������ �� ������ � numberArr
            numbersArr = buffer;
            //��� ������� �������� �������
            for (int i = 0; i < numbersArr.Length; i++)
            {
                //������� �� �����
                Console.WriteLine("�����[" + i + "] = " + numbersArr[i]);
            };








            Console.ReadKey();
        }
        
    }
}
