using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    internal class Message
    {
        public string Text { get; }
        public Message(string text)
        {
            Text = text;
        }
        public virtual void Print() => Console.WriteLine($"{Text}");
    }
}
