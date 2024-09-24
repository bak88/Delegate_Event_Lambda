using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049_КлючевоеСловоIn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();

            Stopwatch sw = Stopwatch.StartNew();

            sw.Start();

            for (int i = 0; i < int.MaxValue; i++)
            {
                Foo(point);
            }

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            sw.Restart();

            
            for (int i = 0; i < int.MaxValue; i++)
            {
                Bar(point);
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);


        }

        struct Point
        {
            public decimal x;
            public decimal y;
            public decimal z;

        }

        static void Foo(Point point)
        {

        }

        static void Bar(in Point point)
        {

        }
    }
}
