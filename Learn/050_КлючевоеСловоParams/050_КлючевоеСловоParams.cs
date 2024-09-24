using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050_КлючевоеСловоParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res = Sum(4, 4, 3, 2, 3, 1); // Пишем не ограниченное кол-во эл-ов

            Test("Text", 2, 3, 4, 53, 2, 4);// Модификатор params, ставится в конце

            Foo("str", 'e', 4, 4.12, 14.88f, true);
        }

        static int Sum(params int[] parameters)
        {
            int result = 0;

            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }

            return result;
        }

        static void Test(string text, params int[] parameters)
        {
            int result = 0;

            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }

            Console.WriteLine(result);
        }

        static void Foo(params object[] elements)
        {
            string message = "Тип данных {0}, значение {1}";

            foreach (var item in elements)
            {
                Console.WriteLine(message, item.GetType(), item);
            }
        }
    }
}
