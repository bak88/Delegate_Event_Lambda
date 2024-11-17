
namespace _ParameterizedThreadStart
{
    internal class Program
    {
        // public delegate void ParameterizedThreadStart(object? obj);
        static void Print(object? message)
        {
            Console.WriteLine(message);
        }
        static void PrintNumber(object? num)
        {
            if (num is int n)
            {
                Console.WriteLine(n * n);
            }
        }
        static void PrintPerson1(object? obj)
        {
            if (obj is Person person)
            {
                Console.WriteLine(person.Name);
                Console.WriteLine(person.Age);
            }
        }
        record class Person(string Name, int Age)
        {
            public void PrintPerson()
            {
                Console.WriteLine(Name);
                Console.WriteLine(Age);
            }
        };
        static void Main(string[] args)
        {

            //Thread thread1 = new Thread(Print);
            //Thread thread2 = new Thread(new ParameterizedThreadStart(Print));
            //Thread thread3 = new Thread(mes => Console.WriteLine(mes));

            //thread1.Start("thread1");
            //thread2.Start("thread2");
            //thread3.Start("thread3");




            //int number = 4;
            //Thread thread = new Thread(PrintNumber);
            //thread.Start(number);



            //Person person = new Person("Jack", 25);
            //Thread thread = new Thread(PrintPerson1);
            //thread.Start(person);




            Person person = new Person("Jack", 28);
            Thread thread = new Thread(person.PrintPerson);
            thread.Start();






        }

    }
}
