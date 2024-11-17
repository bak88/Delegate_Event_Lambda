namespace _Parallel
{
    internal class Program
    {
        static void Print()
        {
            Console.WriteLine($"1 Выполняется задача : {Task.CurrentId}");
            Thread.Sleep(1000);
        }
        static void Square(int n)
        {
            Console.WriteLine($"3 Выполняется задача : {Task.CurrentId}");
            Thread.Sleep(1000);
            Console.WriteLine($"Result {n * n}");
        }
        static void Square1(int n)
        {
            Console.WriteLine($"Выполняется задача {Task.CurrentId}");
            Console.WriteLine($"Квадрат числа {n} равен {n * n}");
            Thread.Sleep(2000);
        }

        static void Square2(int n, ParallelLoopState pls)
        {
            if (n == 2) pls.Break();

            Console.WriteLine($"Квадрат числа {n} равен {n * n}");
            Thread.Sleep(2000);
        }

        static void Main(string[] args)
        {
            //Parallel.Invoke(Print,
            //    () =>
            //    {
            //        Console.WriteLine(($"2 Выполняется задача : {Task.CurrentId}"));
            //        Thread.Sleep(1000);
            //    },
            //    () => Square(5));




            //Parallel.For(1, 5, Square1);




            //ParallelLoopResult result = Parallel.ForEach<int>(
            //    new List<int> { 1, 2, 3, 4 },
            //    Square1
            //);




            ParallelLoopResult result = Parallel.For(1, 10, Square2);
            if(!result.IsCompleted)
                Console.WriteLine($"Выполнение цикла завершено на итерации {result.LowestBreakIteration}");









        }
    }
}
