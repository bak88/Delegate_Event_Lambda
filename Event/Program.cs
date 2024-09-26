namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Account ac = new Account(100);
            ac.Notify += PrintMessage;
            ac.Put(20);

        }
        static void PrintMessage(Account sender, AccountEventArgs e)
        {
            Console.WriteLine($"Сумма транзакции: {e.Sum}");
            Console.WriteLine(e.Message);
            Console.WriteLine($"Текущая сумма на счете: {sender.Sum}");
        }

        static void PrintColorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }


    }
}
