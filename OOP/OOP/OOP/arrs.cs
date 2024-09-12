using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

   public  class arrs
    {
        public  void arr()
        {
            // Создание и вывод двумерного целого массива (матрица)
            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
            Console.WriteLine(" - - - Массивы - - - \n");
            Console.WriteLine("Двумерный массив (матрица):");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t"); // Вывод элементов с табуляцией
                }
                Console.WriteLine(); // Переход на новую строку
            }

            // Создание одномерного массива строк
            string[] words = { "apple", "banana", "cherry", "date" };

            // Вывод содержимого и длины массива
            Console.WriteLine("\nОдномерный массив строк:");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine($"Длина массива: {words.Length}");

            // Замена произвольного элемента по вводу пользователя
            Console.WriteLine("\nВведите индекс элемента, который хотите изменить (0-3):");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите новое значение:");
            string newValue = Console.ReadLine();

            if (index >= 0 && index < words.Length)
            {
                words[index] = newValue;
                Console.WriteLine($"Массив после изменения элемента на позиции {index}:");
                foreach (var word in words)
                {
                    Console.WriteLine(word);
                }
            }
            else
            {
                Console.WriteLine("Некорректный индекс.");
            }

            // Создание ступенчатого массива вещественных чисел
            double[][] jaggedArray = new double[3][];
            jaggedArray[0] = new double[2]; // 2 элемента в первой строке
            jaggedArray[1] = new double[3]; // 3 элемента во второй строке
            jaggedArray[2] = new double[4]; // 4 элемента в третьей строке

            // Ввод значений массива с консоли
            Console.WriteLine("\nВведите значения для ступенчатого массива:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"Элемент [{i}][{j}]: ");
                    jaggedArray[i][j] = double.Parse(Console.ReadLine());
                }
            }

            // Вывод ступенчатого массива
            Console.WriteLine("\nСтупенчатый массив:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
            }

            // Неявно типизированные переменные
            var autoArray = new[] { 1, 2, 3, 4, 5 }; // массив целых чисел
            var autoString = "Неявно типизированная строка"; // строка

            // Вывод неявно типизированных переменных
            Console.WriteLine("\nНеявно типизированные переменные:");
            Console.WriteLine($"Массив: {string.Join(", ", autoArray)}");
            Console.WriteLine($"Строка: {autoString}");





            Console.WriteLine("\n");

        }
    }
}
