using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа находит самое длинное слово в предложении");
            // Ввод данных
            Console.Write("Введите предложение: ");
            string input = Console.ReadLine();
            string[] str = input.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries); // удаляем пробелы и спец. знаки
            int maxlen = 0, index = 0;
            // Решение
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxlen)
                {
                    maxlen = str[i].Length;
                    index = i;
                }
            }
            Console.WriteLine("Самое длинное слово: {0}", str[index]);
            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadLine();
        }
    }
}