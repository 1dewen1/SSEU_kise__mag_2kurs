using System;
using System.Collections.Generic;
using System.Text;

namespace vybor
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод исходных значений
            int A, B, C;
            if (int.TryParse(Console.ReadLine(), out A) && int.TryParse(Console.ReadLine(), out B)
                && int.TryParse(Console.ReadLine(), out C))
            {
                // максимальное значение
                int Max;
                //если A=>B
                if (A >= B)
                {
                    //и если максимальное - A
                    if (A >= C)
                    {
                        // то максимальное - A
                        Max = A;
                    }
                    else
                    {
                        Max = C;
                    }
                }
                // иначе - больше B
                else
                {
                    // и если B >= C
                    if (B >= C)
                    {
                        // то максимальное - B
                        Max = B;
                    }
                    // иначе - C > B
                    else
                    {
                        // максимальное - C
                        Max = C;
                    }
                };

                // вывод результата
                Console.WriteLine("ћаксимальное = " + Max);
                Console.ReadKey();

            }

            else
            {
                Console.WriteLine("Ќеверное значение!Ќужно ввести целое число.");
                Console.ReadKey();
            };

        }
    }
}


