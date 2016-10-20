using System;
using System.Collections.Generic;
using System.Text;

namespace SaleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            double sale;
            int.TryParse(Console.ReadLine(), out sum);
            if (sum > 1000)
            {
                sale = sum - sum * 15 / 100;
                Console.WriteLine("Сумма со скидкой равна " + sale);
                Console.ReadKey();
            }
            else 
            {
                Console.WriteLine("Сумма без скидки равна " + sum);
                Console.ReadKey();
            };
       
        }
    }
}
