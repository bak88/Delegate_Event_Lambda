using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    internal class SmsMessage : Message
    {
        public SmsMessage(string text) :base(text) { }
        public override void Print() => Console.WriteLine($"sms {Text}");
        
    }
}
