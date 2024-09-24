using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_3._3_Array
{
    internal class Program
    {
        // Задайте массив из вещественных чисел с ненулевой дробной частью.Найдите разницу между максимальным и минимальным элементов массива.
        // Начальные условия:
        // int[] array = { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
        // Выводится: 5.15
        static void Main(string[] args)
        {

            double[] arr = { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 };

            // Нахождение минимума массива
            double FindMin(double[] numbers)
            {
                return numbers.Min();
            }

            // Нахождение максимума массива
            double FindMax(double[] numbers)
            {
                return numbers.Max();
            }

            void PrintResult(double[] array)
            {
                Console.WriteLine($"{FindMax(array) - FindMin(array)}");
            }

            PrintResult(arr);
        }
    }
}
