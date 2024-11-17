namespace _CancellationToken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CancellationTokenSource cts = new CancellationTokenSource();
            //CancellationToken token = cts.Token;

            //Task task = new Task(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        if(token.IsCancellationRequested) // проверяем наличие сигнала отмены задачи
            //        {
            //            Console.WriteLine("Операция прервана");
            //            return; //  выходим из метода и тем самым завершаем задачу
            //        }
            //        Console.WriteLine($"Квадрат числа {i} равен {i * i}");
            //        Thread.Sleep(200);
            //    }
            //}, token);
            //task.Start();

            //Thread.Sleep(1000); 
            //cts.Cancel(); // после задержки по времени отменяем выполнение задачи
            //Thread.Sleep(1000);
            //Console.WriteLine($"Task status: {task.Status}");
            //cts.Dispose();





            //CancellationTokenSource cts = new CancellationTokenSource();
            //CancellationToken token = cts.Token;

            //Task task = new Task(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        if(token.IsCancellationRequested) 
            //            token.ThrowIfCancellationRequested(); // генерируем исключение
            //        Console.WriteLine($"Квадрат числа {i} равен {i * i}");
            //        Thread.Sleep(200);
            //    }
            //}, token);

            //try
            //{
            //    task.Start();
            //    Thread.Sleep(1000);
            //    cts.Cancel(); // после задержки по времени отменяем выполнение задачи
            //    //task.Wait();            
            //}
            //catch (AggregateException ae)
            //{
            //    foreach (Exception e in ae.InnerExceptions)
            //    {
            //        if( e is TaskCanceledException)
            //            Console.WriteLine("Операция прервана");
            //        else
            //            Console.WriteLine(e.Message);
            //    }
            //}
            //finally
            //{
            //    cts.Dispose();
            //}
            //Console.WriteLine($"Task Status: {task.Status}"); //  проверяем статус задачи






            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            Task task = new Task(() =>
            {
                int i = 0;
                token.Register(() =>
                {
                    Console.WriteLine("Операция прервана");
                    i = 10;
                });

                for (;1 <10;  i++)
                {
                    Console.WriteLine($"Квадрат числа {i} равен {i * i}");
                    Thread.Sleep(400);
                }
            }, token);
            task.Start();

            Thread.Sleep(1000);
            cts.Cancel(); // после задержки по времени отменяем выполнение задачи
            Thread.Sleep(1000);
            Console.WriteLine($"Task Status: {task.Status}");
            cts.Dispose();












        }
    }
}
