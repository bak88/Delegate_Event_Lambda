namespace _Monitors
{
    internal class Program
    {
        static public int x = 0;
        static public object locker = new();
        static void Print()
        {

            bool acquiredLock = false;
            try
            {
                Monitor.Enter(locker, ref acquiredLock);
                x = 1;
                for (int j = 1; j < 6; j++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} : {x}");
                    x++;
                }
            }
            finally
            {
                if (acquiredLock)
                    Monitor.Exit(locker);
            }
        }

        static void Main(string[] args)
        {
            for (int i = 1; i < 5; i++)
            {
                Thread thread = new Thread(Print);
                thread.Name = $"Thread {i}";
                thread.Start();
            }
        }
    }
}
