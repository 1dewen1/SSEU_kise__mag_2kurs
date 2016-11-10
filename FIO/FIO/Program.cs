using System;
using System.Collections.Generic;
using System.Text;

namespace FIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string i = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string o = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string f = Console.ReadLine();
            string oSokr; //сокращенное отчество
            //И. О. Фамилия
            if (!string.IsNullOrEmpty(o)) //если отчество ввели
            {
                Console.WriteLine(i[0].ToString().ToUpper() + ". " //И.
                         + o[0].ToString().ToUpper() + ". "  //О.
                         +f[0].ToString().ToUpper() //Ф
                         + f.Substring(1).ToLower()); //амилия
                
            }
            else //иначе - отчество не ввели
            {
                Console.WriteLine(i[0].ToString().ToUpper() + ". " //И.
                          +f[0].ToString().ToUpper() //Ф
                          + f.Substring(1).ToLower()); //амилия
              
            };
            //Фамилия И. О.
            if (!string.IsNullOrEmpty(o)) //если отчество ввели
            {
                Console.WriteLine(f[0].ToString().ToUpper() //Ф
                              + f.Substring(1).ToLower() + " "  //амилия
                              + i[0].ToString().ToUpper() + ". " //И.
                              + o[0].ToString().ToUpper()); //О.
            }
            else //иначе - отчество не ввели
            {
                Console.WriteLine(f[0].ToString().ToUpper() //Ф
                              + f.Substring(1).ToLower() + " "  //амилия
                              + i[0].ToString().ToUpper() + ". ");//И.
            };
            //Имя Отчество Фамилия
            if (!string.IsNullOrEmpty(o)) //если отчество ввели
            {
                Console.WriteLine(i[0].ToString().ToUpper() //И
                          + i.Substring(1).ToLower() + " "  //мя
                          + o[0].ToString().ToUpper() //О
                          + o.Substring(1).ToLower() + " "  //тчество
                          + f.ToUpper()); //Фамилия
            }
            else //иначе - отчество не ввели
            {
                Console.WriteLine(i[0].ToString().ToUpper() //И
                          + i.Substring(1).ToLower() + " "  //мя
                          + f.ToUpper()); //Фамилия
            };
            //фам_и_о
            if (!string.IsNullOrEmpty(o)) //если отчество ввели
            {
                Console.WriteLine((f.Substring(0, 3) + "_" //фам_
                               + i.Substring(0, 1) + "_" //и_
                               + o.Substring(0, 1)).ToLower()); //о
            }
            else //иначе - отчество не ввели
            {
                Console.WriteLine((f.Substring(0, 3) + "_" //фам_
                                   + i.Substring(0, 1))); //и
            };
            Console.ReadKey();
        }
    }
}
