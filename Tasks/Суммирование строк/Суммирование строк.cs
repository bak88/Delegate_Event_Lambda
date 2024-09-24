using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Суммирование_строк
{   /* Создайте функцию, которая принимает на вход два целых числа в виде строки и выводит сумму (также в виде строки):

       Пример: ( Ввод1, Ввод2 -->Вывод )

       "4",  "5" --> "9"
       "34", "5" --> "39"
       "", "" --> "0"
       "2", "" --> "2"
       "-5", "3" --> "-2"

       Примечания:

       Если какой-либо вход представляет собой пустую строку, считайте ее равной нулю.

       Входные данные и ожидаемый результат никогда не превысят предел 32-битного целого числа со знаком ( 2^31 - 1).
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringsSum("", ""));
        }

        public static string StringsSum(string s1, string s2)
        {
            //int a = 0;
            //int b = 0;

            //if (s1 != string.Empty)
            //{
            //    a = int.Parse(s1);
            //}
            //if (s2 != string.Empty)
            //{
            //    b = int.Parse(s2);
            //}

            //return (a + b).ToString();

            return $"{(s1 == string.Empty ? 0 : Convert.ToInt32(s1)) + (s2 == string.Empty ? 0 : Convert.ToInt32(s2))}";
        }
    }
}
