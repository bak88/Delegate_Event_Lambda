
namespace Multithreading
{
    internal class Program
    {
        // public delegate void ThreadStart();
        static void Print()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Second thread {i}");
                Thread.Sleep(400);
            }
        }
        
        static void Main(string[] args)
        {

            Thread thread1 = new Thread(Print);
            Thread thread2 = new Thread(new ThreadStart(Print));
            Thread thread3 = new Thread(() => Console.WriteLine("Hi"));

            thread1.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"First thread {i}");
                Thread.Sleep(300);
            }




        }

    }
}
