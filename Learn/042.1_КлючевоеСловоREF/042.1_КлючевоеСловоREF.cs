namespace _042._1_КлючевоеСловоREF
{

    // Ссылочная локальная переменная 

    // Возвращаемые ссылочные значения
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            int a = arr[0];
            a = -5;

            ref int b = ref arr[0]; // Ссылочная локальная переменная 
            b = -5;

            ref int c = ref Foo(arr);
            c = 14;
        }

        static ref int Foo(int[] number) // Возвращаемые ссылочные значения
        {
            return ref number[1];
        }
    }
}
