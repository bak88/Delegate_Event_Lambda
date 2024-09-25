namespace Delegate2
{
    delegate void SomeDel(int a, double b);
    internal class Program
    {
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            int Add(int x, int y) => x + y;
            int Multiply(int x, int y) => x * y;
            void SomeMeth1(int x, double y) { }

            Operation operation = Add; 
            int result = operation(5, 5);
            Console.WriteLine(result);

            operation = new Operation(Multiply);
            result = operation(5, 5);
            Console.WriteLine(result);

            SomeDel someDel = SomeMeth1;
            someDel(3, 3);
            

        }
    }
}
