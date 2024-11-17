namespace ContinuationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task task = new Task(() => Console.WriteLine($"IdTask {Task.CurrentId}"));

            //Task task1 = task.ContinueWith(PrintTask);

            //task.Start();

            //task1.Wait();

            //Console.WriteLine("Finished Main");

            //void PrintTask(Task t)
            //{
            //    Console.WriteLine($"Id Task {Task.CurrentId}");
            //    Console.WriteLine($"Previous task id: {t.Id} ");
            //    Thread.Sleep( 1000 );
            //}





            //Task<int> sumTask = new Task<int>(() => Sum(4, 4));

            //Task printTask = sumTask.ContinueWith(t => PrintResult(t.Result));

            //sumTask.Start();

            //printTask.Wait();

            //Console.WriteLine("Finished Main");

            //int Sum(int a , int b) => a + b;

            //void PrintResult(int sum) => Console.WriteLine(sum);





            //Task task1 = new Task(() => Console.WriteLine($"Current Id {Task.CurrentId}"));

            //Task task2 = task1.ContinueWith(t => Console.WriteLine($"Current Id {Task.CurrentId}, Previous Id {t.Id}"));
            //Task task3 = task2.ContinueWith(t => Console.WriteLine($"Current Id {Task.CurrentId}, Previous Id {t.Id}"));
            //Task task4 = task3.ContinueWith(t => Console.WriteLine($"Current Id {Task.CurrentId}, Previous Id {t.Id}"));

            //task1.Start();
            //task4.Wait();

            //Console.WriteLine("Finished Main");






        }
    }
}
