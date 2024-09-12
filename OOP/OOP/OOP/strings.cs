using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public  class strings
    {
        public  void str(){
            Console.WriteLine(" - - - Строки - - - \n");
            // Объявление строковых литералов
            string str1 = "Hello, world!";
        string str2 = "Hello, world!";
        string str3 = "Hello, Universe!";

        // Сравнение строк
        bool areEqual1 = (str1 == str2); // Сравнение строк с помощью оператора ==
        bool areEqual2 = (str1 == str3); // Сравнение строк с помощью оператора ==

        Console.WriteLine($"Строка 1: {str1}");
            Console.WriteLine($"Строка 2: {str2}");
            Console.WriteLine($"Строка 3: {str3}");
            Console.WriteLine($"Строки 1 и 2 равны: {areEqual1}"); // True, потому что строки идентичны
            Console.WriteLine($"Строки 1 и 3 равны: {areEqual2}"); // False, потому что строки различны
 



            // Создание трёх строк
            string str11 = "Привет";
            string str22 = "мир";
            string str33 = "C#";

            // Сцепление строк
            string concatenated = String.Concat(str1, " ", str2, " в ", str3);
            Console.WriteLine($"Сцепление: {concatenated}");

            // Копирование строки
            string copiedStr = String.Copy(str1);
            Console.WriteLine($"Копирование: {copiedStr}");

            // Выделение подстроки
            string substring = concatenated.Substring(7, 3); // выделим "мир"
            Console.WriteLine($"Подстрока: {substring}");

            // Разделение строки на слова
            string[] words = concatenated.Split(' ');
            Console.WriteLine("Разделение строки на слова:");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            // Вставка подстроки в заданную позицию
            string insertedStr = concatenated.Insert(7, "прекрасный ");
            Console.WriteLine($"Вставка подстроки: {insertedStr}");

            // Удаление подстроки
            string removedSubstring = insertedStr.Remove(7, 11); // удалим "прекрасный"
            Console.WriteLine($"Удаление подстроки: {removedSubstring}");

            // Интерполяция строк
            string interpolatedStr = $"Программа на {str3}, которая выводит: {concatenated}";
            Console.WriteLine($"Интерполирование строк: {interpolatedStr}");





            // Создаем пустую строку
            string emptyString = "";

            // Создаем null строку
            string nullString = null;

            // Проверяем, является ли строка пустой или null
            Console.WriteLine(string.IsNullOrEmpty(emptyString)); // true для пустой строки
            Console.WriteLine(string.IsNullOrEmpty(nullString));  // true для null строки

            // Пример строки с содержимым
            string nonEmptyString = "Привет!";
            Console.WriteLine(string.IsNullOrEmpty(nonEmptyString)); // false, т.к. строка не пуста

            // Пример конкатенации пустой строки
            string result1 = emptyString + "Привет"; // "Привет"
            Console.WriteLine(result1); // Выведет "Привет"

            // Пример конкатенации null строки
            string result2 = nullString + "Привет"; // "Привет"
            Console.WriteLine(result2); // Выведет "Привет"

            // Проверка длины пустой строки
            Console.WriteLine(emptyString.Length); // 0 для пустой строки

            // Сравнение пустой и null строк
            Console.WriteLine(emptyString == nullString); // false, т.к. они не равны

            // Сравнение строк с использованием string.Compare
            Console.WriteLine(string.Compare(emptyString, nullString)); // 1, т.к. emptyString "больше" null






            // Создаем строку с помощью StringBuilder
            StringBuilder sb = new StringBuilder("Привет, мир!");

            // Удаляем символы с 7-й позиции (начиная с 0) длиной 4 символа ("мир")
            sb.Remove(7, 4);

            // Добавляем новые символы в начало строки
            sb.Insert(0, "Здравствуй, ");

            // Добавляем новые символы в конец строки
            sb.Append("!!!");

            // Выводим итоговую строку
            Console.WriteLine(sb.ToString()); // Здравствуй, Привет, !!!
            Console.WriteLine("\n");

        }

    }
    
}
