namespace _Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task task1 = Task.Factory.StartNew(() => Console.WriteLine("Task.Factory.StartNew()"));

            //Task task2 = Task.Run(() => Console.WriteLine("Task.Run()"));




            //Console.WriteLine("Main starts");
            //Task task = new Task(() =>
            //{
            //    Console.WriteLine("Task starts");
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Task ends");
            //}); 
            //task.Start();

            //Console.WriteLine("Main ends");
            //task.Wait();




            //Console.WriteLine("Main starts");
            //Task task = new Task(() =>
            //{
            //    Console.WriteLine("Task starts");
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Task ends");
            //});
            //task.RunSynchronously();

            //Console.WriteLine("Main ends");





            Task task = new Task(() =>
            {
                Console.WriteLine($"Task {Task.CurrentId} Starts");
                Thread.Sleep( 1000 );
                Console.WriteLine($"Task {Task.CurrentId} ends");
            });
            task.Start();

            Console.WriteLine($"task Id: {task.Id}");
            Console.WriteLine($"task is Completed: {task.IsCompleted}");
            Console.WriteLine($"task Status: {task.Status}");

            task.Wait();







        }
    }
}
