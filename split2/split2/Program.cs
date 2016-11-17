using System;
using System.Collections.Generic;
using System.Text;

namespace split2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¬ведите числа через ;");
            string numbersStr = Console.ReadLine();
            //разбить строку по символу ;
            string[] numbersStrArr = numbersStr.Split(';');
            //массив чисел той же длины, что и массив строк
            double[] numbersArr = new double[numbersStrArr.Length];
            //дл€ каждого элемента массива
            int n = 0;
            for (int i = 0; i < numbersStrArr.Length; i++)
            {
                //преобразуем строки без пробелов в числа 
                if (double.TryParse(numbersStrArr[i].Trim(), out numbersArr[i]))
                {
                    n++;
                    
                };
            };
            //временный массив длинной n
            double[] buffer = new double[n];
            for (int i = 0; i < n; i++)
            {
                //копируем в буфер
                buffer[i] = numbersArr[i];
            };
            //копируем получившийс€ массив из буфера в numberArr
            numbersArr = buffer;
            //дл€ каждого элемента массива
            for (int i = 0; i < numbersArr.Length; i++)
            {
                //вывести на экран
                Console.WriteLine("число[" + i + "] = " + numbersArr[i]);
            };








            Console.ReadKey();
        }
        
    }
}
