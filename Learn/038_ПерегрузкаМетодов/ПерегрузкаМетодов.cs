using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038_ПерегрузкаМетодов
{
    internal class ПерегрузкаМетодов
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(2.0, 3.4));
        }


        /// <summary>
        /// Возвращает сумму двух чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b) => a + b;
        

        /// <summary>
        /// Возвращает сумму трех чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int Sum(int a, int b, int c) => a + b + c;
        
        static double Sum(double a, double b) => a + b;
        
    }
}
