using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateUsing
{
    public delegate void AccountHandler(string message);
    internal class Account
    {
        int sum;
        AccountHandler? taken;
        public Account(int sum) => this.sum = sum;
        public void RegisterHandler(AccountHandler method)
        {
            taken += method;
        }
        public void UnregisterHandler(AccountHandler method)
        {
            taken -= method;
        }
        public void Add(int sum) => this.sum += sum;
        public void Take(int sum)
        {
            if (this.sum >= sum)
            {
                this.sum -= sum;
                taken?.Invoke($"Со счёта снята {sum}");
            }
            else
            {
                taken?.Invoke($"Не достаточно средств {this.sum}");
            }
        }

    }
}
