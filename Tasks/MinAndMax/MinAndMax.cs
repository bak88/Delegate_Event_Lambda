using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAndMax
{
    /* Напишите функцию, которая возвращает 
     * минимальное и максимальное число данного списка/массива.
     */

    internal class MinAndMax
    {
        static void Main(string[] args)
        {

            Console.WriteLine(string.Join(",", minMax(new int[] { 1, 2, 5, -1, 12, 20 })));


        }
        public static int[] minMax(int[] lst)
        {
            return new[] { lst.Min(), lst.Max() };
        }
            
    }
}
