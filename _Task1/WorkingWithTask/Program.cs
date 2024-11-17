using System.Threading.Channels;

namespace WorkingWithTask
{
    record class Person(string Name, int Age);
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task outer = Task.Factory.StartNew(() =>
            //{
            //    Console.WriteLine("Outer task starting..");
            //    Task inner = Task.Factory.StartNew(() =>
            //    {
            //        Console.WriteLine("Inner task starting...");
            //        Thread.Sleep(2000);
            //        Console.WriteLine("Inner task finished.");
            //    }, TaskCreationOptions.AttachedToParent);
            //});
            //outer.Wait();
            //Console.WriteLine("End of Main");




            //Task[] taskArr = new Task[3]
            //{
            //    new Task(() => Console.WriteLine("1")),
            //    new Task(() => Console.WriteLine("2")),
            //    new Task(() => Console.WriteLine("3"))
            //};

            //foreach (var task in taskArr) 
            //    task.Start();


            //Task[] tasks = new Task[3];

            //for (int i = 0; i < tasks.Length; i++)
            //{
            //    tasks[i] = new Task(() =>
            //    {
            //        Thread.Sleep(100);
            //        Console.WriteLine($" Task{i} finished");
            //    });
            //    tasks[i].Start();
            //}
            //Console.WriteLine("Finished Main");
            //Task.WaitAll(tasks);





            //int n1 = 4;
            //int n2 = 5;

            //Task<int> sumTask = new Task<int>(() => Sum(n1, n2));
            //sumTask.Start();

            //int res = sumTask.Result;

            //Console.WriteLine(res);
            //int Sum(int n1, int n2) => n1 + n2;





            Task<Person> personTask = new Task<Person>(() => new Person("Jack", 25));
            personTask.Start();

            Person person = personTask.Result;
            Console.WriteLine($"{person.Name} - {person.Age}");

        }
    }
}
