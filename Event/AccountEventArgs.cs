using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class AccountEventArgs
    {
        public string Message { get; }
        public int Sum {  get; }

        public AccountEventArgs(string mes, int sum)
        {
            Sum = sum;
            Message = mes;
        }
    }
}
