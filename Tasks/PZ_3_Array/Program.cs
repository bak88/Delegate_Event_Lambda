using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_3_Array
{
    internal class Program
    {
        // Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке[10, 90].
        // Начальные условия:
        // int[] array = { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 }; // Создание массива
        // Выводится: 5

        static void Main(string[] args)
        {
            int min = 10;
            int max = 90;
            int[] arr = { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 };

            // Подсчет количества элементов массива, попадающих в заданный диапазон
            // numbers - массив, в котором ведется подсчет
            // minRange - минимальная граница диапазона
            // maxRange - максимальная граница диапазона
            int CountItemsRange(int[] numbers, int minRange, int maxRange)
            {
                int count = 0;
                foreach (var item in numbers)
                {
                    if (item >= minRange && item <= maxRange)
                    {
                        count++;
                    }
                }
                return count;
            }

            void PrintResult(int[] array)
            {
                
               Console.WriteLine(CountItemsRange(array, min, max));
            }

            PrintResult(arr);
        }
    }
}
