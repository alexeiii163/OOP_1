using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public  class cort
    {
        public void corts()
        {
            Console.WriteLine(" - - - Кортежи - - - \n");
            // Создание кортежа с типами int, string, char, string, ulong
            var tuple = (1, "Hello", 'A', "World", 1234567890123456789UL);

            // Вывод всего кортежа на консоль
            Console.WriteLine("Full tuple: " + tuple);

            // Вывод выборочных элементов
            Console.WriteLine($"Element 1: {tuple.Item1}");
            Console.WriteLine($"Element 3: {tuple.Item3}");
            Console.WriteLine($"Element 4: {tuple.Item4}");

            // Распаковка кортежа в переменные
            (int num, string str1, char ch, string str2, ulong ulongNum) = tuple;
            Console.WriteLine($"Unpacked values: {num}, {str1}, {ch}, {str2}, {ulongNum}");

            // Альтернативные способы распаковки
            var (n, s1, c, s2, u) = tuple;
            Console.WriteLine($"Unpacked using var: {n}, {s1}, {c}, {s2}, {u}");

            // Использование переменной ( _ ) для игнорирования некоторых элементов
            var (number, _, character, _, bigNumber) = tuple;
            Console.WriteLine($"Ignored elements: {number}, {character}, {bigNumber}");

            // Сравнение двух кортежей
            var tuple1 = (1, "Hello", 'A', "World", 1234567890123456789UL);
            var tuple2 = (1, "Hello", 'A', "World", 1234567890123456789UL);
            var tuple3 = (2, "Hello", 'A', "World", 1234567890123456789UL);

            Console.WriteLine($"tuple1 == tuple2: {tuple1 == tuple2}"); // True
            Console.WriteLine($"tuple1 == tuple3: {tuple1 == tuple3}"); // False


            Console.WriteLine("\n");

        }
    }
}
