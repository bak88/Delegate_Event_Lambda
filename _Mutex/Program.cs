
namespace _Mutex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Mutex mutex = new Mutex();

            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(Print);
                thread.Name = $"Thread : {i}";
                thread.Start();
            }
            void Print()
            {
                mutex.WaitOne();
                for (int i = 1; i < 6; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                    x++;
                    Thread.Sleep(100);
                }
                mutex.ReleaseMutex();
            }
        }

    }
}
