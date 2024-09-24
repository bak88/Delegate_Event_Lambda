using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047_КлючевоеСловоOUT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int.TryParse(str, out int res);

            Console.WriteLine(res);
        }

        static void Foo(ref int value)
        {
            value++;
            Console.WriteLine(value);
        }

        static void Bar(out int value)
        {
            value = 10;
            Console.WriteLine(value);
        }
    }
}
