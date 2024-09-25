using DelegateUsing;
using System.Threading.Channels;

namespace DelegateUnseeing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(10);
            account.RegisterHandler(PrintMessage);
            account.RegisterHandler(PrintColorMessage);
            account.Take(3);
            account.Take(10);
            account.UnregisterHandler(PrintMessage);
            account.Take(10);
        }

        static void PrintMessage(string message) => Console.WriteLine(message);
        static void PrintColorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
