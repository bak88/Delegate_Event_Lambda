using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053_Рекурсия
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Foo(0);
        }

        static void Foo(int i)
        {

            if (i >= 3)
            {
                return;
            }

            Console.WriteLine(i);
            i++;

            Foo(i);
        }
    }
}
