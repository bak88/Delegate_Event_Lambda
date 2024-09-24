using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            method1 z = new method1();

            int a = 23, b = 0, c;

            c = z.fun(++b * --a % 2);

            int d = (z.fun(c-- + --a));

            int e = 10 % 9;

            Console.WriteLine(c); 
            Console.WriteLine(a++); 
            Console.WriteLine(d);
        }
    }

    class method1 
    {
        public int fun(int m)
        {
            return (m++ % 10);
        }
    }
}
