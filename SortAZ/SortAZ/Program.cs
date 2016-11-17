using System;
using System.Collections.Generic;
using System.Text;

namespace SortAZ
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод строки
            Console.WriteLine("¬ведите слова, разделенные пробелами:");
            string words = Console.ReadLine();
            //преобразование строки в массив, разделитель - пробел
            string[] wordsArr = words.Split(' ');
            //сортировка массива
            Array.Sort(wordsArr);
            //собираем массив обратно в строку
            words = wordsArr[0];
            for (int i = 1; i < wordsArr.Length; i++)
                words = words + " " + wordsArr[i];
            //вывод результата на экран
            Console.WriteLine("—ортировка по алфавиту");
            Console.WriteLine(words);



            Console.ReadKey();
        }
    }
}
