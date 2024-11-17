namespace ThreadsSynchronization
{
    internal class Program
    {
        static public int x = 0;
        static public object locker = new object();
        static public void Print()
        {
            lock (locker)
            {
                x = 1;
                for (int i = 1; i < 6; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} : {x}");
                    x++;
                    Thread.Sleep(100);
                }

            }
        }
        static void Main(string[] args)
        {


            for (int i = 1; i < 6; i++)
            {
                Thread thread = new Thread(Print);
                thread.Name = $"Thread {i}";
                thread.Start();
            }

        }
    }
}
