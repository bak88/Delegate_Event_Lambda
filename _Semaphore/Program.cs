
namespace _Semaphore
{
    class Reader
    {
        static Semaphore sem = new Semaphore(3, 3);
        Thread thread;
        int count = 3;

        public Reader(int i)
        {
            thread = new Thread(Read);
            thread.Name = $"Reader : {i}";
            thread.Start();
        }

        public void Read()
        {
            while (count > 0)
            {
                sem.WaitOne();
                Console.WriteLine($"{Thread.CurrentThread.Name} входит в библиотеку");

                Console.WriteLine($"{Thread.CurrentThread.Name} читает");
                Thread.Sleep(1000);

                Console.WriteLine($"{Thread.CurrentThread.Name} покидает библиотеку");
                sem.Release();

                count--;
                Thread.Sleep(1000);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
                Reader reader = new Reader(i);
            }
        }
    }
}
