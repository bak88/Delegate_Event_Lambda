using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {

            M m = new M();
            N n = new N();
            M mn = new N();

            m.A();
            n.C();
            mn.C();
            mn.B();

        }
    }
    public class M
    {
        public void A()
        {
            Console.WriteLine("M-A");
        }

        public virtual void B()
        {
            Console.WriteLine("M-B");
        }

        public void C()
        {
            Console.WriteLine("M-C");
        }
    }

    public class N : M
    {
        public void A()
        {
            Console.WriteLine("N-A");
        }
        public  void B()
        {
            Console.WriteLine("N-B");
        }

        public void C()
        {
            Console.WriteLine("N-C");
        }
    }

}
