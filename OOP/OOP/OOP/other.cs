using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class other
    {
        public void oth()
        {

            Console.WriteLine(" - - - Другое - - - \n");
            // Примерные данные
            int[] numbers = { 5, 3, 9, 1, 6 };
            string text = "Hello";

            // Локальная функция для вычисления статистики массива и строки
            (int max, int min, int sum, char firstLetter) GetStatistics(int[] arr, string str)
            {
                if (arr.Length == 0)
                    throw new ArgumentException("Array cannot be empty.");

                int max = arr[0];
                int min = arr[0];
                int sum = 0;

                foreach (int number in arr)
                {
                    if (number > max)
                        max = number;
                    if (number < min)
                        min = number;
                    sum += number;
                }

                char firstLetter = str.Length > 0 ? str[0] : throw new ArgumentException("String cannot be empty.");

                return (max, min, sum, firstLetter);
            }

            // Вызов локальной функции и получение результата
            var result = GetStatistics(numbers, text);

            // Вывод результатов
            Console.WriteLine($"Максимальный элемент: {result.max}");
            Console.WriteLine($"Минимальный элемент: {result.min}");
            Console.WriteLine($"Сумма элементов: {result.sum}");
            Console.WriteLine($"Первая буква строки: {result.firstLetter}");




            // Локальная функция с блоком checked
            void CheckedOverflow()
            {
                try
                {
                    checked
                    {
                        // Определение переменной с максимальным значением int и попытка переполнения
                        int maxValue = int.MaxValue;
                        int overflowedValue = maxValue + 1; // Это приведет к переполнению
                        Console.WriteLine($"Checked Overflow Value: {overflowedValue}");
                    }
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine($"Checked Overflow Exception: {ex.Message}");
                }
            }

            // Локальная функция с блоком unchecked
            void UncheckedOverflow()
            {
                unchecked
                {
                    // Определение переменной с максимальным значением int и попытка переполнения
                    int maxValue = int.MaxValue;
                    int overflowedValue = maxValue + 1; // Это приведет к переполнению
                    Console.WriteLine($"Unchecked Overflow Value: {overflowedValue}");
                }
            }

            // Вызов локальных функций
            CheckedOverflow();
            UncheckedOverflow();
            Console.WriteLine("\n");
        }

    }

}
