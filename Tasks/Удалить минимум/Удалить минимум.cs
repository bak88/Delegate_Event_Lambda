using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Удалить_минимум
{
    /* Учитывая массив целых чисел, удалите наименьшее значение. Не изменяйте исходный массив/список. 
     * Если существует несколько элементов с одинаковым значением, удалите элемент с наименьшим индексом. 
     * Если вы получили пустой массив/список, верните пустой массив/список.
     * Не меняйте порядок оставшихся элементов.
     * 
     * Input: [1,2,3,4,5], output = [2,3,4,5]
     * Input: [5,3,2,1,4], output = [5,3,2,4]
     * Input: [2,2,1,2,1], output = [2,2,2,1]
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in RemoveSmallest(new List<int> { 1,2,1,4,1}))
            {
                Console.Write(item + " ");
            }
            
        }

        public static List<int> RemoveSmallest(List<int> numbers)
        {
            if (numbers.Count == 0) return numbers;

            numbers.Remove(numbers.Min());

            return numbers;

            //numbers.Remove(numbers.DefaultIfEmpty().Min());
            //return numbers;
        }
    }
}
