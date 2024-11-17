namespace _AutoResetEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            AutoResetEvent waitHandler = new AutoResetEvent(true);

            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(Print);
                thread.Name = $"Thread : {i}";
                thread.Start();
            }

            void Print()
            {
                waitHandler.WaitOne();
                x = 1;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} : {x}");
                    x++;
                    // Thread.Sleep(100);
                }
                waitHandler.Set();
            }
        }
    }
}
