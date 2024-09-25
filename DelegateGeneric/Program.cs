namespace DelegateGeneric
{
    internal class Program
    {
        delegate T Operation<T, K>(K k);
        static void Main(string[] args)
        {
            Operation<decimal, int> op = Square;
            Console.WriteLine(op.Invoke(5));
            
            Operation<int, int> op2 = Double;
            Console.WriteLine(op2.Invoke(4));
        }

        static decimal Square(int x) => x * x;
        static int Double(int x) => x + x;
    }
}
