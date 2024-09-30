using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{

    internal class Account
    {
        public delegate void AccountHandler(Account sender, AccountEventArgs e);
        public event AccountHandler? Notify;
        public int Sum { get; private set; }
        public Account(int sum) => Sum = sum;
        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke(this, new AccountEventArgs($"На счет поступило {sum}", sum));
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke(this, new AccountEventArgs($"Со счета снято {sum}", sum));
            }
            else
            {
                Notify?.Invoke(this, new AccountEventArgs($"Недостаточно средств {sum} ", sum));
            }

        }
    }
}
