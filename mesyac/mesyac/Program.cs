using System;
using System.Collections.Generic;
using System.Text;

namespace mesyac
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            if (int.TryParse(Console.ReadLine(), out m))
            // выбор мес€ца
            switch (m)
            {
            case 1: Console.WriteLine("январь"); break;
            case 2: Console.WriteLine("‘евраль"); break;
            case 3: Console.WriteLine("ћарт"); break;
            case 4: Console.WriteLine("јпрель"); break;
            case 5: Console.WriteLine("ћай"); break;
            case 6: Console.WriteLine("»юнь"); break;
            case 7: Console.WriteLine("»юль"); break;
            case 8: Console.WriteLine("јвгуст"); break;
            case 9: Console.WriteLine("январь"); break;
            case 10: Console.WriteLine("—ент€брь"); break;
            case 11: Console.WriteLine("ќкт€брь"); break;
            case 12: Console.WriteLine("ƒекабрь"); break;
            default: Console.WriteLine("“акого мес€ца не сущесвует."); break;
            }
            Console.ReadKey();
        }
    }
}
