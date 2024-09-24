using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_3._2_Array
{
    internal class Program
    {
        // Задайте массив на 10 целых чисел.Напишите программу, которая определяет количество чётных чисел в массиве.
        // Начальные условия:
        // int[] array = { 2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
        // Выводится: 6

        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 2, 3, 6, 3, 7, 8, 2, 4 };

            // Подсчет количества четных элементов массива
            // numbers - массив, в котором ведется подсчет
            int CountEvenItems(int[] numbers)
            {
                int count = 0;

                foreach (var item in numbers)
                {
                    if (item % 2 == 0)
                    {
                        count++;
                    }
                }
                return count;
            }

            void PrintResult(int[] array)
            {
                Console.WriteLine(CountEvenItems(array));
            }

            PrintResult(arr);
        }
    }
}
