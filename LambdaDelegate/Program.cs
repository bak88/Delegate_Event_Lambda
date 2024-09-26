namespace LambdaDelegate
{
    internal class Program
    {
        delegate void Message();
        delegate int Operation(int x, int y);
        delegate void PrintHandler(string message);
        delegate bool IsEqual(int x);
        static void Main(string[] args)
        {
            //var message = () =>
            //{
            //    Console.WriteLine("HI");
            //    Console.WriteLine("YOU are The Best");
            //};
            //message.Invoke();

            //Operation sum = (x, y) => Console.WriteLine(x * y);
            //sum.Invoke(3, 3);

            //var operation = (int x, int y) => Console.WriteLine(x + y);
            //operation.Invoke(3, 3);

            //PrintHandler mes = mes => Console.WriteLine(mes);
            //mes.Invoke("dsfsaf");

            //var mes1 = (string message = "Hello") => Console.WriteLine(message);
            //mes1.Invoke();
            //mes1.Invoke("Jack");





            //var sum = (int x, int y) => x * y;
            //int res = sum.Invoke(3,4);
            //Console.WriteLine(res);

            //sum = (int x, int y) =>
            //{
            //    if (x > y)
            //        return x + y;
            //    else
            //        return y - x;
            //};
            //res = sum.Invoke(3,4);
            //Console.WriteLine(res);





            //var hello = () => Console.WriteLine("Hello");
            //var message = () => Console.WriteLine("Man");
            //message += hello;
            //message += () => Console.WriteLine("You are the best");
            //message += Print;
            //message.Invoke();
            //Console.WriteLine("-------------");
            //message -= hello;
            //message?.Invoke();




            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };            
            //int res = Sum(arr, x => x > 5);
            //Console.WriteLine(res);
            //res = Sum(arr, x => x % 2 == 1);
            //Console.WriteLine(res);




            Operation operation = SelectOperation(OperationType.Add);
            Console.WriteLine(operation.Invoke(4,4));
            operation = SelectOperation(OperationType.Subtract);
            Console.WriteLine(operation.Invoke(10,6));





        }

        static void Print() => Console.WriteLine("Welcome to C#");
        static int Sum(int[] arr, IsEqual isEqual)
        {
            int res = 0;
            foreach (var x in arr)
            {
                if (isEqual(x)) res += x;
            }
            return res;
        }

        static Operation SelectOperation(OperationType op)
        {
            switch (op)
            {
                case OperationType.Add: return (x, y) => x + y;
                case OperationType.Subtract: return (x, y) => x - y;
                default: return (x, y) => x * y;
            }
        }
    }
}
