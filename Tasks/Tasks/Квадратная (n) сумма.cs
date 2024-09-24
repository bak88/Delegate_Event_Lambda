using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Program
    {
        /*Завершите функцию суммы квадратов так, чтобы она возводила в квадрат каждое переданное в нее число, 
         * а затем суммировала результаты. 
         * Например, для [1, 2, 2]него следует вернуться, 9 потому что 1^1 + 2^2 + 4^4 = 21
         */

        static void Main(string[] args)
        {
            Console.WriteLine(SquareSum(new[] { 5, 4, 3 }));
        }

        
        public static int SquareSum(int[] numbers)
        {
            return numbers.Sum(x => x * x);
        }
    }
}
