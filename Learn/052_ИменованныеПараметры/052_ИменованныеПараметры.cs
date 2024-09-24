using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _052_ИменованныеПараметры
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 3;
            int secondNumber = 5;

            Sum(firstNumber, secondNumber, enableLogger: true);

            Sum(enableLogger: true, b: secondNumber, a: firstNumber ) ;

            Console.WriteLine(Sum(b: 3, a: 4));
        }

        static int Sum(int a, int b, bool enableLogger = false)
        {
            int result = a + b;

            if (enableLogger)
            {
                Console.WriteLine("{0} + {1} = {2}", a, b, result);
            }
            return result;
        }
    }
}
