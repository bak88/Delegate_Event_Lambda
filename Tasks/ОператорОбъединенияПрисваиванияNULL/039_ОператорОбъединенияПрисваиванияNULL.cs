namespace ОператорОбъединенияПрисваиванияNULL
{

    // Оператор объединения с NUll ??=

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = GetArray();

            arr ??= new int[5];

            Console.WriteLine("Длинна массива: " + arr.Length);
        }

        static int[] GetArray()
        {
            int[] array = new int[3];
            return array;
        }
    }
}
