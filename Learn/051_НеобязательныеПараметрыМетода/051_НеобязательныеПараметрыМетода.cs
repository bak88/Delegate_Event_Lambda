using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _051_НеобязательныеПараметрыМетода
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum(3, 4, true, 4);
        }

        static int Sum(int a, int b, bool isBool = false, int c )
        {
            int res = a + b;

            if (isBool)
            {
                Console.WriteLine($"{a} + {b} = {res}");
            }

            return res;

        }
    }
}
