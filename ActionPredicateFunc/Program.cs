namespace ActionPredicateFunc
{
    internal class Program
    {
        delegate void Action();
        delegate void Action<in T>(T obj);

        delegate bool Predicate<in T>(T obj);

        delegate T Func<out T>();
        delegate T Func<in M, out T>(M obj);
        static void Main(string[] args)
        {
            //void DoOperation(int x, int y, Action<int, int> action) => action(x, y);
            //DoOperation(1, 2, Add);


            //Predicate<int> predicate = (int x) => x > 0;
            //Console.WriteLine(predicate(-1));


            int Operation(int a, Func<int, int> f) => f(a);
            int DoubleNumber(int n) => n * 2;
            int SquareNumber(int n) => n * n;

            int res = Operation(3, DoubleNumber);
            Console.WriteLine(res);
            res = Operation(3, SquareNumber);
            Console.WriteLine(res);
        }

        static void Add(int x, int y) => Console.WriteLine(x + y);
        static void Multiply(int x, int y) => Console.WriteLine(x + y);
    }
}
